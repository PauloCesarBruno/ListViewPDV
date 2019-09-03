namespace Estudo_ListView_Estilo_PDV
{
    partial class frmManipulacaoProdutos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblProduto = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblBuscaNome = new System.Windows.Forms.Label();
            this.txtBuscaProduto = new System.Windows.Forms.TextBox();
            this.lblBuscaCodigo = new System.Windows.Forms.Label();
            this.txtBuscaCodigo = new System.Windows.Forms.TextBox();
            this.btnBuscaCodigo = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvProdutos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProdutos.BackgroundColor = System.Drawing.Color.White;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Produto,
            this.Valor});
            this.dgvProdutos.Location = new System.Drawing.Point(6, 16);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutos.Size = new System.Drawing.Size(593, 433);
            this.dgvProdutos.TabIndex = 12;
            this.dgvProdutos.TabStop = false;
            this.dgvProdutos.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellEnter);
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Blue;
            this.Codigo.DefaultCellStyle = dataGridViewCellStyle2;
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Produto
            // 
            this.Produto.DataPropertyName = "Produto";
            this.Produto.HeaderText = "Produto";
            this.Produto.Name = "Produto";
            this.Produto.ReadOnly = true;
            this.Produto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Produto.Width = 350;
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "Valor";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.Valor.DefaultCellStyle = dataGridViewCellStyle3;
            this.Valor.HeaderText = "  Valor Produto";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            this.Valor.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(12, 591);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 61);
            this.btnNovo.TabIndex = 6;
            this.btnNovo.Text = "&Add. Produto";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Enabled = false;
            this.btnInserir.Location = new System.Drawing.Point(111, 591);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 61);
            this.btnInserir.TabIndex = 7;
            this.btnInserir.Text = "&Inserir Produto";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Enabled = false;
            this.btnAlterar.Location = new System.Drawing.Point(211, 591);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 61);
            this.btnAlterar.TabIndex = 8;
            this.btnAlterar.Text = "Alterar &Produto";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Location = new System.Drawing.Point(308, 591);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 61);
            this.btnExcluir.TabIndex = 9;
            this.btnExcluir.Text = "&Excluir Produto";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(405, 591);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 61);
            this.btnAtualizar.TabIndex = 10;
            this.btnAtualizar.Text = "A&tualizar Lista";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(526, 623);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(66, 29);
            this.btnSair.TabIndex = 11;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(140, 473);
            this.txtProduto.MaxLength = 44;
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(333, 20);
            this.txtProduto.TabIndex = 4;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(13, 456);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 8;
            this.lblCodigo.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(16, 473);
            this.txtCodigo.MaxLength = 13;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(106, 20);
            this.txtCodigo.TabIndex = 3;
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(137, 456);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(44, 13);
            this.lblProduto.TabIndex = 10;
            this.lblProduto.Text = "Produto";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(489, 456);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(31, 13);
            this.lblValor.TabIndex = 11;
            this.lblValor.Text = "Valor";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(492, 473);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 5;
            // 
            // lblBuscaNome
            // 
            this.lblBuscaNome.AutoSize = true;
            this.lblBuscaNome.Location = new System.Drawing.Point(13, 523);
            this.lblBuscaNome.Name = "lblBuscaNome";
            this.lblBuscaNome.Size = new System.Drawing.Size(129, 13);
            this.lblBuscaNome.TabIndex = 13;
            this.lblBuscaNome.Text = "Buscar por Nome Produto";
            // 
            // txtBuscaProduto
            // 
            this.txtBuscaProduto.Location = new System.Drawing.Point(16, 540);
            this.txtBuscaProduto.Name = "txtBuscaProduto";
            this.txtBuscaProduto.Size = new System.Drawing.Size(270, 20);
            this.txtBuscaProduto.TabIndex = 0;
            this.txtBuscaProduto.TextChanged += new System.EventHandler(this.txtBuscaProduto_TextChanged);
            // 
            // lblBuscaCodigo
            // 
            this.lblBuscaCodigo.AutoSize = true;
            this.lblBuscaCodigo.Location = new System.Drawing.Point(305, 523);
            this.lblBuscaCodigo.Name = "lblBuscaCodigo";
            this.lblBuscaCodigo.Size = new System.Drawing.Size(134, 13);
            this.lblBuscaCodigo.TabIndex = 14;
            this.lblBuscaCodigo.Text = "Buscar por Código Produto";
            // 
            // txtBuscaCodigo
            // 
            this.txtBuscaCodigo.Location = new System.Drawing.Point(308, 540);
            this.txtBuscaCodigo.MaxLength = 13;
            this.txtBuscaCodigo.Name = "txtBuscaCodigo";
            this.txtBuscaCodigo.Size = new System.Drawing.Size(115, 20);
            this.txtBuscaCodigo.TabIndex = 1;
            // 
            // btnBuscaCodigo
            // 
            this.btnBuscaCodigo.Location = new System.Drawing.Point(429, 539);
            this.btnBuscaCodigo.Name = "btnBuscaCodigo";
            this.btnBuscaCodigo.Size = new System.Drawing.Size(31, 21);
            this.btnBuscaCodigo.TabIndex = 2;
            this.btnBuscaCodigo.Text = "OK";
            this.btnBuscaCodigo.UseVisualStyleBackColor = true;
            this.btnBuscaCodigo.Click += new System.EventHandler(this.btnBuscaCodigo_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnImprimir.Location = new System.Drawing.Point(492, 523);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(100, 61);
            this.btnImprimir.TabIndex = 15;
            this.btnImprimir.Text = "&Imprimir produtos";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // frmManipulacaoProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 668);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnBuscaCodigo);
            this.Controls.Add(this.txtBuscaCodigo);
            this.Controls.Add(this.lblBuscaCodigo);
            this.Controls.Add(this.txtBuscaProduto);
            this.Controls.Add(this.lblBuscaNome);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblProduto);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtProduto);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.dgvProdutos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmManipulacaoProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produtos:";
            this.Load += new System.EventHandler(this.frmManipulacaoProdutos_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmManipulacaoProdutos_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblBuscaNome;
        private System.Windows.Forms.TextBox txtBuscaProduto;
        private System.Windows.Forms.Label lblBuscaCodigo;
        private System.Windows.Forms.TextBox txtBuscaCodigo;
        private System.Windows.Forms.Button btnBuscaCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.Button btnImprimir;
    }
}