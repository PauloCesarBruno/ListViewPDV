namespace Estudo_ListView_Estilo_PDV
{
    partial class frmPDV
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPDV));
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.Lista = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblSomatorio = new System.Windows.Forms.Label();
            this.lblReais = new System.Windows.Forms.Label();
            this.btnFecharConta = new System.Windows.Forms.Button();
            this.btnDeletaItem = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTot = new System.Windows.Forms.Label();
            this.lblQuant = new System.Windows.Forms.Label();
            this.lblVal = new System.Windows.Forms.Label();
            this.lblProd = new System.Windows.Forms.Label();
            this.lblCod = new System.Windows.Forms.Label();
            this.btnEstoque = new System.Windows.Forms.Button();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.txtProduto2 = new System.Windows.Forms.TextBox();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.lblLembrete = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblX = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblProgramador = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.lblGramas = new System.Windows.Forms.Label();
            this.txtCalc = new System.Windows.Forms.TextBox();
            this.txtTot = new System.Windows.Forms.TextBox();
            this.panelCxLivre = new System.Windows.Forms.Panel();
            this.lblCxLivre = new System.Windows.Forms.Label();
            this.lblSomatorio2 = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.PDVDataSet = new Estudo_ListView_Estilo_PDV.PDVDataSet();
            this.tbl_ProdutosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_ProdutosTableAdapter = new Estudo_ListView_Estilo_PDV.PDVDataSetTableAdapters.tbl_ProdutosTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelCxLivre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PDVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_ProdutosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(24, 106);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(27, 123);
            this.txtCodigo.MaxLength = 13;
            this.txtCodigo.Multiline = true;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(151, 33);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCodigo_KeyUp);
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(402, 232);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(24, 20);
            this.txtProduto.TabIndex = 1;
            this.txtProduto.Visible = false;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(434, 232);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(23, 20);
            this.txtValor.TabIndex = 2;
            this.txtValor.Visible = false;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(198, 113);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(27, 13);
            this.lblQuantidade.TabIndex = 6;
            this.lblQuantidade.Text = "Qtd.";
            // 
            // txtQtd
            // 
            this.txtQtd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtQtd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtd.Location = new System.Drawing.Point(212, 132);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(34, 20);
            this.txtQtd.TabIndex = 3;
            this.txtQtd.Text = "1";
            this.txtQtd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQtd_KeyDown);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(39, 428);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "Total";
            this.lblTotal.Visible = false;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(42, 445);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(28, 20);
            this.txtTotal.TabIndex = 4;
            this.txtTotal.TabStop = false;
            this.txtTotal.Text = "0";
            this.txtTotal.Visible = false;
            // 
            // Lista
            // 
            this.Lista.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.Lista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Lista.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.Lista.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lista.FullRowSelect = true;
            this.Lista.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.Lista.HideSelection = false;
            this.Lista.HoverSelection = true;
            this.Lista.Location = new System.Drawing.Point(389, 151);
            this.Lista.Name = "Lista";
            this.Lista.Size = new System.Drawing.Size(647, 434);
            this.Lista.TabIndex = 100;
            this.Lista.UseCompatibleStateImageBehavior = false;
            this.Lista.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Cód.";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Produto";
            this.columnHeader2.Width = 320;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Valor";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Qtd.";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 40;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Total";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader5.Width = 80;
            // 
            // lblSomatorio
            // 
            this.lblSomatorio.AutoSize = true;
            this.lblSomatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSomatorio.Location = new System.Drawing.Point(934, 588);
            this.lblSomatorio.Name = "lblSomatorio";
            this.lblSomatorio.Size = new System.Drawing.Size(0, 29);
            this.lblSomatorio.TabIndex = 101;
            // 
            // lblReais
            // 
            this.lblReais.AutoSize = true;
            this.lblReais.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReais.Location = new System.Drawing.Point(895, 588);
            this.lblReais.Name = "lblReais";
            this.lblReais.Size = new System.Drawing.Size(45, 29);
            this.lblReais.TabIndex = 102;
            this.lblReais.Text = "R$";
            // 
            // btnFecharConta
            // 
            this.btnFecharConta.Enabled = false;
            this.btnFecharConta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFecharConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFecharConta.Location = new System.Drawing.Point(27, 507);
            this.btnFecharConta.Name = "btnFecharConta";
            this.btnFecharConta.Size = new System.Drawing.Size(169, 78);
            this.btnFecharConta.TabIndex = 103;
            this.btnFecharConta.Text = "&Fechar Venda";
            this.btnFecharConta.UseVisualStyleBackColor = true;
            this.btnFecharConta.Click += new System.EventHandler(this.btnFecharConta_Click);
            // 
            // btnDeletaItem
            // 
            this.btnDeletaItem.Enabled = false;
            this.btnDeletaItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeletaItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletaItem.Location = new System.Drawing.Point(201, 507);
            this.btnDeletaItem.Name = "btnDeletaItem";
            this.btnDeletaItem.Size = new System.Drawing.Size(169, 78);
            this.btnDeletaItem.TabIndex = 104;
            this.btnDeletaItem.TabStop = false;
            this.btnDeletaItem.Text = "&Remover Item";
            this.btnDeletaItem.UseVisualStyleBackColor = true;
            this.btnDeletaItem.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblTot);
            this.panel1.Controls.Add(this.lblQuant);
            this.panel1.Controls.Add(this.lblVal);
            this.panel1.Controls.Add(this.lblProd);
            this.panel1.Controls.Add(this.lblCod);
            this.panel1.Location = new System.Drawing.Point(389, 132);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(647, 19);
            this.panel1.TabIndex = 105;
            // 
            // lblTot
            // 
            this.lblTot.AutoSize = true;
            this.lblTot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTot.Location = new System.Drawing.Point(549, 2);
            this.lblTot.Name = "lblTot";
            this.lblTot.Size = new System.Drawing.Size(69, 13);
            this.lblTot.TabIndex = 4;
            this.lblTot.Text = "Valor Total";
            // 
            // lblQuant
            // 
            this.lblQuant.AutoSize = true;
            this.lblQuant.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuant.Location = new System.Drawing.Point(507, 2);
            this.lblQuant.Name = "lblQuant";
            this.lblQuant.Size = new System.Drawing.Size(31, 13);
            this.lblQuant.TabIndex = 3;
            this.lblQuant.Text = "Qtd.";
            // 
            // lblVal
            // 
            this.lblVal.AutoSize = true;
            this.lblVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVal.Location = new System.Drawing.Point(438, 2);
            this.lblVal.Name = "lblVal";
            this.lblVal.Size = new System.Drawing.Size(60, 13);
            this.lblVal.TabIndex = 2;
            this.lblVal.Text = "Valor Un.";
            // 
            // lblProd
            // 
            this.lblProd.AutoSize = true;
            this.lblProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProd.Location = new System.Drawing.Point(104, 2);
            this.lblProd.Name = "lblProd";
            this.lblProd.Size = new System.Drawing.Size(51, 13);
            this.lblProd.TabIndex = 1;
            this.lblProd.Text = "Produto";
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCod.Location = new System.Drawing.Point(4, 2);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(46, 13);
            this.lblCod.TabIndex = 0;
            this.lblCod.Text = "Código";
            // 
            // btnEstoque
            // 
            this.btnEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEstoque.Location = new System.Drawing.Point(27, 600);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Size = new System.Drawing.Size(134, 26);
            this.btnEstoque.TabIndex = 106;
            this.btnEstoque.Text = "&Manipular Estoque";
            this.btnEstoque.UseVisualStyleBackColor = true;
            this.btnEstoque.Click += new System.EventHandler(this.btnEstoque_Click);
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(165, 536);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutos.Size = new System.Drawing.Size(13, 10);
            this.dgvProdutos.TabIndex = 107;
            this.dgvProdutos.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellEnter);
            // 
            // txtProduto2
            // 
            this.txtProduto2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtProduto2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProduto2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProduto2.ForeColor = System.Drawing.Color.Black;
            this.txtProduto2.Location = new System.Drawing.Point(30, 406);
            this.txtProduto2.Multiline = true;
            this.txtProduto2.Name = "txtProduto2";
            this.txtProduto2.Size = new System.Drawing.Size(344, 64);
            this.txtProduto2.TabIndex = 108;
            // 
            // txtValor2
            // 
            this.txtValor2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtValor2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor2.ForeColor = System.Drawing.Color.Black;
            this.txtValor2.Location = new System.Drawing.Point(30, 468);
            this.txtValor2.Multiline = true;
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(198, 28);
            this.txtValor2.TabIndex = 109;
            // 
            // lblLembrete
            // 
            this.lblLembrete.AutoSize = true;
            this.lblLembrete.Location = new System.Drawing.Point(39, 415);
            this.lblLembrete.Name = "lblLembrete";
            this.lblLembrete.Size = new System.Drawing.Size(283, 13);
            this.lblLembrete.TabIndex = 110;
            this.lblLembrete.Text = "Estas Caixas estão Invisíveis, porém elas que computam...";
            this.lblLembrete.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblTitulo);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(-2, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1064, 100);
            this.panel2.TabIndex = 111;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Monotype Corsiva", 45F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(292, 12);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(706, 72);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Teste Piloto Sistema de P.D.V.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(262, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.Location = new System.Drawing.Point(195, 135);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(15, 13);
            this.lblX.TabIndex = 112;
            this.lblX.Text = "X";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.lblProgramador);
            this.panel3.Location = new System.Drawing.Point(-2, 632);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1064, 23);
            this.panel3.TabIndex = 113;
            // 
            // lblProgramador
            // 
            this.lblProgramador.AutoSize = true;
            this.lblProgramador.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgramador.ForeColor = System.Drawing.Color.Blue;
            this.lblProgramador.Location = new System.Drawing.Point(-2, 4);
            this.lblProgramador.Name = "lblProgramador";
            this.lblProgramador.Size = new System.Drawing.Size(248, 13);
            this.lblProgramador.TabIndex = 0;
            this.lblProgramador.Text = "Por Paulo Cesar C. Bruno - Desenvolvedor";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(27, 171);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(344, 232);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 114;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 511);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 115;
            this.label1.Text = "F1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(205, 512);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 116;
            this.label2.Text = "F2";
            // 
            // txtCod
            // 
            this.txtCod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtCod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCod.Location = new System.Drawing.Point(256, 133);
            this.txtCod.MaxLength = 5;
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(100, 20);
            this.txtCod.TabIndex = 117;
            this.txtCod.Visible = false;
            this.txtCod.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCod_KeyUp);
            // 
            // lblGramas
            // 
            this.lblGramas.AutoSize = true;
            this.lblGramas.Location = new System.Drawing.Point(253, 113);
            this.lblGramas.Name = "lblGramas";
            this.lblGramas.Size = new System.Drawing.Size(115, 13);
            this.lblGramas.TabIndex = 118;
            this.lblGramas.Text = "digite peso em gramas.";
            this.lblGramas.Visible = false;
            // 
            // txtCalc
            // 
            this.txtCalc.Location = new System.Drawing.Point(390, 106);
            this.txtCalc.Name = "txtCalc";
            this.txtCalc.Size = new System.Drawing.Size(38, 20);
            this.txtCalc.TabIndex = 119;
            this.txtCalc.Visible = false;
            // 
            // txtTot
            // 
            this.txtTot.Location = new System.Drawing.Point(437, 106);
            this.txtTot.Name = "txtTot";
            this.txtTot.Size = new System.Drawing.Size(63, 20);
            this.txtTot.TabIndex = 120;
            this.txtTot.Visible = false;
            // 
            // panelCxLivre
            // 
            this.panelCxLivre.BackColor = System.Drawing.Color.Transparent;
            this.panelCxLivre.Controls.Add(this.lblCxLivre);
            this.panelCxLivre.Location = new System.Drawing.Point(27, 409);
            this.panelCxLivre.Name = "panelCxLivre";
            this.panelCxLivre.Size = new System.Drawing.Size(344, 90);
            this.panelCxLivre.TabIndex = 121;
            this.panelCxLivre.Visible = false;
            // 
            // lblCxLivre
            // 
            this.lblCxLivre.AutoSize = true;
            this.lblCxLivre.Font = new System.Drawing.Font("Monotype Corsiva", 45F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCxLivre.ForeColor = System.Drawing.Color.Black;
            this.lblCxLivre.Location = new System.Drawing.Point(-2, 8);
            this.lblCxLivre.Name = "lblCxLivre";
            this.lblCxLivre.Size = new System.Drawing.Size(343, 72);
            this.lblCxLivre.TabIndex = 0;
            this.lblCxLivre.Text = "Caixa Livre ...";
            this.lblCxLivre.Visible = false;
            // 
            // lblSomatorio2
            // 
            this.lblSomatorio2.AutoSize = true;
            this.lblSomatorio2.Location = new System.Drawing.Point(708, 600);
            this.lblSomatorio2.Name = "lblSomatorio2";
            this.lblSomatorio2.Size = new System.Drawing.Size(52, 13);
            this.lblSomatorio2.TabIndex = 122;
            this.lblSomatorio2.Text = "somatório";
            this.lblSomatorio2.Visible = false;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(766, 588);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(126, 29);
            this.lblSubTotal.TabIndex = 123;
            this.lblSubTotal.Text = "SubTotal:";
            // 
            // PDVDataSet
            // 
            this.PDVDataSet.DataSetName = "PDVDataSet";
            this.PDVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_ProdutosBindingSource
            // 
            this.tbl_ProdutosBindingSource.DataMember = "tbl_Produtos";
            this.tbl_ProdutosBindingSource.DataSource = this.PDVDataSet;
            // 
            // tbl_ProdutosTableAdapter
            // 
            this.tbl_ProdutosTableAdapter.ClearBeforeFill = true;
            // 
            // frmPDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1058, 656);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSomatorio2);
            this.Controls.Add(this.panelCxLivre);
            this.Controls.Add(this.txtTot);
            this.Controls.Add(this.btnEstoque);
            this.Controls.Add(this.txtCalc);
            this.Controls.Add(this.lblGramas);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblLembrete);
            this.Controls.Add(this.txtValor2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblReais);
            this.Controls.Add(this.lblSomatorio);
            this.Controls.Add(this.Lista);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtQtd);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtProduto);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtProduto2);
            this.Controls.Add(this.btnDeletaItem);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnFecharConta);
            this.Controls.Add(this.dgvProdutos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmPDV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "P.D.V.:";
            this.Load += new System.EventHandler(this.frmPDV_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPDV_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelCxLivre.ResumeLayout(false);
            this.panelCxLivre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PDVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_ProdutosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblSomatorio;
        private System.Windows.Forms.Label lblReais;
        private System.Windows.Forms.Button btnFecharConta;
        private System.Windows.Forms.Button btnDeletaItem;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ListView Lista;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTot;
        private System.Windows.Forms.Label lblQuant;
        private System.Windows.Forms.Label lblVal;
        private System.Windows.Forms.Label lblProd;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.Button btnEstoque;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.TextBox txtProduto2;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.Label lblLembrete;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblProgramador;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Label lblGramas;
        private System.Windows.Forms.TextBox txtCalc;
        private System.Windows.Forms.TextBox txtTot;
        private System.Windows.Forms.Panel panelCxLivre;
        private System.Windows.Forms.Label lblCxLivre;
        private System.Windows.Forms.Label lblSomatorio2;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.BindingSource tbl_ProdutosBindingSource;
        private PDVDataSet PDVDataSet;
        private PDVDataSetTableAdapters.tbl_ProdutosTableAdapter tbl_ProdutosTableAdapter;
    }
}

