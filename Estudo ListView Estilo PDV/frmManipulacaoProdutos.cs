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

namespace Estudo_ListView_Estilo_PDV
{
    public partial class frmManipulacaoProdutos : Form
    {
        Conect conect = new Conect();

        public frmManipulacaoProdutos()
        {
            InitializeComponent();
            dgvProdutos.AutoGenerateColumns = false;
        }

        #region Métodos

        private void LimpaCampos ()
        {
            txtCodigo.Text = String.Empty;
            txtProduto.Text = String.Empty;
            txtValor.Text = String.Empty;
            txtBuscaProduto.Text = String.Empty;
            txtBuscaCodigo.Text = String.Empty;
            txtCodigo.Focus();
        }

        private void CarregarGrid()
        {
            try
            {
                Produtos_Colecao Pcolecao = new Produtos_Colecao();
                Negocios_Produtos Nprodutos = new Negocios_Produtos();
                Pcolecao = Nprodutos.BuscaNome(txtBuscaProduto.Text);
                dgvProdutos.DataSource = null;
                dgvProdutos.DataSource = Pcolecao;
                dgvProdutos.Update();
                dgvProdutos.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO, Detalhe: " + ex.Message);
            }
        }

        private void BuscaCodigo()
        {
            try
            {
                Produtos_Colecao Pcolecao = new Produtos_Colecao();
                Negocios_Produtos Nprodutos = new Negocios_Produtos();
                Pcolecao = Nprodutos.BuscarCodigo (Convert.ToInt64 (txtBuscaCodigo.Text));
                dgvProdutos.DataSource = null;
                dgvProdutos.DataSource = Pcolecao;
                dgvProdutos.Update();
                dgvProdutos.Refresh();
            }
            catch (Exception)
            {
                //
            }
        }

        private void Inserir()
        {
            try
            {
                Produtos produtos = new Produtos();
                Negocios_Produtos Nprodutos = new Negocios_Produtos();
                produtos.Codigo = Convert.ToInt64(txtCodigo.Text);
                produtos.Produto = Convert.ToString(txtProduto.Text);
                produtos.Valor = Convert.ToDecimal(txtValor.Text);
                Nprodutos.Inserir(produtos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO, Detalhe: " + ex.Message);
            }
        }

        private void Alterar()
        {
            try
            {
                Produtos produtos = new Produtos();
                Negocios_Produtos Nprodutos = new Negocios_Produtos();
                produtos.Codigo = Convert.ToInt64(txtCodigo.Text);
                produtos.Produto = Convert.ToString(txtProduto.Text);
                produtos.Valor = Convert.ToDecimal(txtValor.Text);
                Nprodutos.Alterar (produtos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO, Detalhe: " + ex.Message);
            }
        }

        private void Excluir()
        {
            try
            {
                Produtos produtos = new Produtos();
                Negocios_Produtos Nprodutos = new Negocios_Produtos();
                produtos.Codigo = Convert.ToInt64(txtCodigo.Text);
                Nprodutos.Excluir (produtos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO, Detalhe: " + ex.Message);
            }
        }

        #endregion

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmManipulacaoProdutos_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void dgvProdutos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow  linha = this.dgvProdutos.Rows[e.RowIndex];
            txtCodigo.Text = (linha.Cells[0].Value.ToString());
            txtProduto.Text = (linha.Cells[1].Value.ToString());
            txtValor.Text = (String.Format("{0:N}", linha.Cells[2].Value));

        }

        private void txtBuscaProduto_TextChanged(object sender, EventArgs e)
        {
            CarregarGrid();
            if (dgvProdutos.Rows.Count < 1)
            {
                MessageBox.Show("Produto não encontrado no cadastro!!!", "P.D.V.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LimpaCampos();
                CarregarGrid();
                btnInserir.Enabled = false;
                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;
                txtBuscaProduto.Focus();
            }
            else
            {
                btnInserir.Enabled = true;
                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;
            }
        }

        private void btnBuscaCodigo_Click(object sender, EventArgs e)
        {
            if (txtBuscaCodigo .Text == String .Empty)
            {
                MessageBox.Show("Por favor digite o Código!!!", "P.D.V.", MessageBoxButtons.OK, MessageBoxIcon.Warning);                
                btnInserir.Enabled = false;
                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;
                LimpaCampos();
                CarregarGrid();
                txtBuscaCodigo.Focus();
                return;
            }

            BuscaCodigo(); 
            
            if (dgvProdutos.Rows.Count < 1)
            {
                MessageBox.Show("Produto não encontrado no cadastro!!!", "P.D.V.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LimpaCampos();
                CarregarGrid();
                btnInserir.Enabled = false;
                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;
                txtBuscaCodigo.Focus();
            }
            else
            {
                btnInserir.Enabled = true;
                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {           
            if (txtCodigo .Text == "" || txtProduto.Text == "" || txtValor.Text == "")
            {
                MessageBox.Show("Atenção: é necessário preencher todos os campos para registro de novo produto", "AVISO:", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigo.Focus();
            }           
            Inserir();
            LimpaCampos();
            CarregarGrid();
            btnInserir.Enabled = false;
            txtBuscaProduto.Focus();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            btnInserir.Enabled = true;
            LimpaCampos();
            txtCodigo.Focus();
        }

        private void frmManipulacaoProdutos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Alterar();           
            LimpaCampos();
            CarregarGrid();
            btnInserir.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            txtBuscaProduto.Focus();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            LimpaCampos();
            CarregarGrid();
            btnInserir.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            txtBuscaProduto.Focus();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult perg = MessageBox.Show("Deseja relamente exluir esse registri sim ou não ?", "P.D.V.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (perg != DialogResult.Yes)
            {
                MessageBox.Show("OK, Mantendo o Registro", "P.D.V.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpaCampos();
                CarregarGrid();
                btnInserir.Enabled = false;
                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;
                txtBuscaProduto.Focus();
            }
            else
            {
                Excluir();              
                LimpaCampos();
                CarregarGrid();
                btnInserir.Enabled = false;
                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;
                txtBuscaProduto.Focus();
                MessageBox.Show("Registro excluido com êxito !", "P.D.V.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            frmImpressao imp = new frmImpressao();
            imp.Show();
        }
    }
}