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
    public partial class frmPagamento : Form
    {
        public frmPagamento(Decimal valor)
        {
            InitializeComponent();
            txtValor.Text = String.Format("{0:N}", valor);
        }

        private void frmPagamento_Load(object sender, EventArgs e)
        {
            //
        }

        private void rbDinheiro_CheckedChanged(object sender, EventArgs e)
        {
            frmMoney fm = new frmMoney(Convert.ToDecimal(txtValor.Text));
            fm.ShowDialog();
            this.Close();
        }

        private void frmPagamento_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {

                case Keys.F1:
                    frmMoney fm = new frmMoney(Convert.ToDecimal(txtValor.Text));
                    fm.ShowDialog();
                    this.Close();

                    break;
                case Keys.F2:
                    // A ser Implementado...
                    break;

                case Keys.F3:
                    // A ser Implementado...
                    break;

                case Keys.F4:
                    // A ser Implementado...
                    break;
            }
        }
    }
}