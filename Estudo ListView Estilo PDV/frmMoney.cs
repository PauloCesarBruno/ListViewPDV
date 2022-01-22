using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudo_ListView_Estilo_PDV
{
    public partial class frmMoney : Form
    {
        public frmMoney(Decimal val)
        {
            InitializeComponent();
            txtVal.Text = String.Format("{0:N}", val); 
        }

        private void frmMoney_Load(object sender, EventArgs e)
        {
           
        }

        private void frmMoney_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void btnCalcula_Click(object sender, EventArgs e)
        {
            Decimal valor, pagamento, troco;

            valor = Convert.ToDecimal (txtVal.Text);

            if (txtPagamento.Text == String.Empty)
            {
                MessageBox.Show("É necesário digitar o valor do Pagamento", "ERRO!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPagamento.Focus();
                return;
            }
            pagamento = Convert.ToDecimal(txtPagamento.Text);
          
            troco = pagamento - valor;

            txtTroco.Text = troco.ToString();
        }
    }
}
