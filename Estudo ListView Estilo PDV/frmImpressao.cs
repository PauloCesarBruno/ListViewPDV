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
    public partial class frmImpressao : Form
    {
        public frmImpressao()
        {
            InitializeComponent();
        }

        private void frmImpressao_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'PDVDataSet.tbl_Produtos'. Você pode movê-la ou removê-la conforme necessário.
            this.tbl_ProdutosTableAdapter.Fill(this.PDVDataSet.tbl_Produtos);

            this.reportViewer1.RefreshReport();
        }
    }
}
