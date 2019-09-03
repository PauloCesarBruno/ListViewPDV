namespace Estudo_ListView_Estilo_PDV
{
    partial class frmImpressao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tbl_ProdutosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PDVDataSet = new Estudo_ListView_Estilo_PDV.PDVDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tbl_ProdutosTableAdapter = new Estudo_ListView_Estilo_PDV.PDVDataSetTableAdapters.tbl_ProdutosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_ProdutosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PDVDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tbl_ProdutosBindingSource
            // 
            this.tbl_ProdutosBindingSource.DataMember = "tbl_Produtos";
            this.tbl_ProdutosBindingSource.DataSource = this.PDVDataSet;
            // 
            // PDVDataSet
            // 
            this.PDVDataSet.DataSetName = "PDVDataSet";
            this.PDVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.tbl_ProdutosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Estudo_ListView_Estilo_PDV.RelEstoque.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // tbl_ProdutosTableAdapter
            // 
            this.tbl_ProdutosTableAdapter.ClearBeforeFill = true;
            // 
            // frmImpressao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmImpressao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmImpressao";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmImpressao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_ProdutosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PDVDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tbl_ProdutosBindingSource;
        private PDVDataSet PDVDataSet;
        private PDVDataSetTableAdapters.tbl_ProdutosTableAdapter tbl_ProdutosTableAdapter;
    }
}