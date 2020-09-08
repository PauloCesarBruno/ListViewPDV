using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//
using System.Data.SqlClient;
using DTO;
using Regras_de_Negocios;
using ConexaoSql;

/* Alguns Lembretes para o ListView:
 * =========================================
 * Melhor Fonte para PDV é a CourrierNew...
 * HearderStyle colocar NONE e fazer o
 * cabeçãlho com Panel e Label´s....*/

namespace Estudo_ListView_Estilo_PDV
{
    public partial class frmPDV : Form
    {
        Decimal total; // Variavel (Global)
        // de controle do total da TexeBox (txtCodigo)....
        Controle_Atributos ca = new Controle_Atributos();

        public frmPDV()
        {
            InitializeComponent();
        }

        #region Métodos

        private void Limpar_Campos()
        {
            txtCodigo.Text = String.Empty;
            txtProduto.Text = String.Empty;
            txtValor.Text = String.Empty;
            txtQtd.Text = "1";
            txtCodigo.Focus();
        }

        private void BuscaCodigo()
        {
            try
            {
                Produtos_Colecao Pcolecao = new Produtos_Colecao();
                Negocios_Produtos Nprodutos = new Negocios_Produtos();
                Pcolecao = Nprodutos.BuscarCodigo(Convert.ToInt64(txtCodigo.Text));
                dgvProdutos.DataSource = null;   // DGV Escondido Atraz do Botão Fechar
                dgvProdutos.DataSource = Pcolecao;
                dgvProdutos.Update();
                dgvProdutos.Refresh();
            }
            catch (Exception)
            {
                //
            }
        }

        private void Somatorio()
        {
            // Somatório da Coluna Total, gerando um Label com Valor Total.
            var total = 0m;
            for (int i = 0; i < Lista.Items.Count; i++)
            {
                total += decimal.Parse(Lista.Items[i].SubItems[4].Text);
            }

            lblSomatorio.Text = total.ToString("N2");
        }

        #endregion //=======================================================================================================================================//

        private void btnFecharConta_Click(object sender, EventArgs e)
        {   
            ListViewItem lvi = new ListViewItem(ca.codigo.ToString());
            if (Lista.Items.Count < 1)
            {
                btnDeletaItem.Enabled = false;
                btnFecharConta.Enabled = false;
            }
            else
            {
                btnDeletaItem.Enabled = true;
                btnFecharConta.Enabled = true;
            }
            lblSomatorio2.Text = lblSomatorio.Text; // Manter o Valor do somatório para jogar para o frmPagamento (lblSomatorio2 - INVISÍVEL).
            frmPagamento pg = new frmPagamento(Convert.ToDecimal(lblSomatorio2.Text));
            pg.ShowDialog();

            panelCxLivre.Visible = true;
            lblCxLivre.Visible = true;
            btnDeletaItem.Enabled = false;
            btnFecharConta.Enabled = false;

            Lista.Items.Clear();           
            lblSomatorio.Text = String.Empty;
            Limpar_Campos();
            txtProduto2.Text = String.Empty;
            txtValor2.Text = String.Empty;
            txtCalc.Text = String.Empty;
            txtTot.Text = String.Empty;
            txtCod.Text = String.Empty;
            txtCod.Visible = false;
            lblGramas.Visible = false;
            txtQtd.Enabled = true;
            txtCodigo.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Lista.SelectedItems[0].Remove();
                Somatorio(); // Chamada do método para somar coluna de Total.
                txtCodigo.Focus();
            }
            catch (Exception)
            {
                MessageBox.Show("Marque o Item a ser removido...", "P.D.V.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            frmManipulacaoProdutos mp = new frmManipulacaoProdutos();
            mp.ShowDialog();
        }

        private void dgvProdutos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtProduto.Text = dgvProdutos.CurrentRow.Cells[1].Value.ToString();
            txtValor.Text = dgvProdutos.CurrentRow.Cells[2].Value.ToString();
        }

        private void txtCodigo_KeyUp(object sender, KeyEventArgs e)
        {
            panelCxLivre.Visible = false;
            lblCxLivre.Visible = false;

            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    BuscaCodigo();
                    if (txtCodigo.TextLength >= 2 && dgvProdutos.Rows.Count < 1)
                    {
                        MessageBox.Show("PRODUTO NÃO CADASTRADO", "P.D.V.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtCodigo.Text = string.Empty;
                        txtQtd.Text = "1";
                        txtCodigo.Focus();
                    }
                   
                    // HABILITA PARA O CÁLCULO DE PESO em  txtCod_KeyUp (*)......
                    // ================================================================                    
                    if (txtCodigo.Text.Length != 13 && txtCodigo.Text.Length != 0)
                    {
                        txtCod.Visible = true;
                        lblGramas.Visible = true;
                        txtQtd.Enabled = false;
                        txtCod.Focus();
                                               

                        txtProduto2.Text = txtProduto.Text;
                        txtValor2.Text = "R$ " + txtValor.Text;

                        txtTot.Text = dgvProdutos.CurrentRow.Cells[2].Value.ToString();
                        total = Convert.ToDecimal(txtTot.Text);
                    }
                    //=================================================================
                    else
                    {

                        ca.codigo = Convert.ToInt64(txtCodigo.Text);
                        ca.produto = txtProduto.Text;
                        ca.valor = Convert.ToDecimal(txtValor.Text);
                        ca.qtd = Convert.ToByte(txtQtd.Text);
                        ca.total = Convert.ToDecimal(txtTotal.Text);

                        txtProduto2.Text = txtProduto.Text;
                        txtValor2.Text = "R$ " + txtValor.Text;

                        // Calcula quanidade vezes valor (pegando o objeto "ca" da Classe "Controle_Atributos".
                        ca.tgeral = ca.qtd * ca.valor; 

                        ListViewItem lvi = new ListViewItem(ca.codigo.ToString());
                        lvi.SubItems.Add(ca.produto);
                        lvi.SubItems.Add(String.Format("{0:N}", ca.valor));
                        lvi.SubItems.Add("x " + ca.qtd.ToString());
                        lvi.SubItems.Add(String.Format("{0:N}", ca.tgeral));
                        Lista.Items.Add(lvi);

                        if (Lista.Items.Count < 1)
                        {
                            btnDeletaItem.Enabled = false;
                            btnFecharConta.Enabled = false;
                        }
                        else
                        {
                            btnDeletaItem.Enabled = true;
                            btnFecharConta.Enabled = true;
                        }
                       
                        Lista.EnsureVisible(Lista.Items.Count - 1); // Rolagem Automática de um ListView.

                        Somatorio(); // Chamada do método para somar coluna de Total.
                        Limpar_Campos();
                        dgvProdutos.DataSource = null; // Zera o Datasource para quando der "Enter" sem ter nada lançado, bloqueie...                       
                    }
                }
            }
            catch (Exception)
            {
                //
            }
        }

        private void txtCod_KeyUp(object sender, KeyEventArgs e)
        {
            // CÁLCULO DE PESO (*)......
            // ================================================================
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    BuscaCodigo();
                    Int32 gramas;
                    Decimal calc;

                    gramas = Convert.ToInt32(txtCod.Text);
                    calc = (total / 1000) * gramas;
                    txtCalc.Text = calc.ToString();

                    ca.codigo = Convert.ToInt64(txtCodigo.Text);
                    ca.produto = txtProduto.Text + " Kg " + dgvProdutos .CurrentRow.Cells [2].Value.ToString () + "  " +  " (" +gramas  + " g" + ")";
                    ca.valor = Convert.ToDecimal(txtValor.Text);                    
                    ca.total = Convert.ToDecimal(txtTotal.Text);

                    txtProduto2.Text = txtProduto.Text;
                    txtValor2.Text = "R$ " + txtValor.Text;

                    ca.tgeral = ca.qtd * ca.valor; // Calcula quanidade vezes valor (pegando o objeto "ca" da Classe "Controle_Atributos".

                    ListViewItem lvi = new ListViewItem(ca.codigo.ToString());
                    lvi.SubItems.Add(ca.produto);
                    lvi.SubItems.Add(String.Format("{0:N}", calc));
                    lvi.SubItems.Add("x 1");
                    lvi.SubItems.Add(String.Format("{0:N}", calc));
                    Lista.Items.Add(lvi);

                    if (Lista.Items.Count < 1)
                    {
                        btnDeletaItem.Enabled = false;
                        btnFecharConta.Enabled = false;
                    }
                    else
                    {
                        btnDeletaItem.Enabled = true;
                        btnFecharConta.Enabled = true;
                    }

                    if (Lista.Items.Count < 1)
                    {
                        btnFecharConta.Enabled = false;
                    }
                    else
                    {
                        btnFecharConta.Enabled = true;
                    }

                    Lista.EnsureVisible(Lista.Items.Count - 1); // Rolagem Automática de um ListView.

                    Somatorio(); // Chamada do método para somar coluna de Total.
                    txtCalc.Text = String.Empty;
                    txtTot.Text = String.Empty;
                    txtCod.Text = String.Empty;
                    txtCod.Visible = false;
                    lblGramas.Visible = false;
                    txtQtd.Enabled = true;
                    txtCodigo.Focus();
                    Limpar_Campos();
                    dgvProdutos.DataSource = null; // Zera o Datasource para quando der "Enter" sem ter nada lançado, bloqueie...
                }
            }
            catch (Exception)
            {
                //
            }
        }

        private void frmPDV_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {

                case Keys.F1:                   
                    if (Lista.Items.Count < 1)
                    {
                        btnDeletaItem.Enabled = false;
                        btnFecharConta.Enabled = false;
                    }
                    else
                    {
                        ListViewItem lvi = new ListViewItem(ca.codigo.ToString());
                        if (Lista.Items.Count < 1)
                        {
                            btnDeletaItem.Enabled = true;
                            btnFecharConta.Enabled = true;
                        }
                        lblSomatorio2.Text = lblSomatorio.Text; // Manter o Valor do somatório para jogar para o frmPagamento (lblSomatorio2 - INVISÍVEL).
                        frmPagamento pg = new frmPagamento(Convert.ToDecimal(lblSomatorio2.Text));
                        pg.ShowDialog();

                        Lista.Items.Clear();
                        lblSomatorio.Text = String.Empty;
                        Limpar_Campos();
                        txtProduto2.Text = String.Empty;
                        txtValor2.Text = String.Empty;
                        btnDeletaItem.Enabled = false;
                        btnFecharConta.Enabled = false;
                    }
                    break;


                case Keys.F2:
                    try
                    {
                        Lista.SelectedItems[0].Remove();
                        Somatorio(); // Chamada do método para somar coluna de Total.
                        txtCodigo.Focus();


                        if (Lista.Items.Count < 1)
                        {
                            btnDeletaItem.Enabled = false;
                            btnFecharConta.Enabled = false;
                        }
                        else
                        {
                            btnDeletaItem.Enabled = true;
                            btnFecharConta.Enabled = true;
                        }
                    }
                    catch (Exception)
                    {
                         MessageBox.Show("Marque o Item a ser removido...", "P.D.V.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;
            }
        }

        private void txtQtd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCodigo.Focus();
            }
        }

        private void frmPDV_Load(object sender, EventArgs e)
        {
            panelCxLivre.Visible = true;
            lblCxLivre.Visible = true;
            ListViewItem lvi = new ListViewItem(ca.codigo.ToString());
            if (Lista.Items.Count < 1)
            {
                btnDeletaItem.Enabled = false;
                btnFecharConta.Enabled = false;
            }
            else
            {
                btnDeletaItem.Enabled = true;
                btnFecharConta.Enabled = true;
            }                 
        }
    }
}