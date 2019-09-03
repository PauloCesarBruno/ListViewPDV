namespace Estudo_ListView_Estilo_PDV
{
    partial class frmMoney
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMoney));
            this.txtVal = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtPagamento = new System.Windows.Forms.TextBox();
            this.lblPagamento = new System.Windows.Forms.Label();
            this.txtTroco = new System.Windows.Forms.TextBox();
            this.lblTroco = new System.Windows.Forms.Label();
            this.btnCalcula = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtVal
            // 
            this.txtVal.BackColor = System.Drawing.SystemColors.Control;
            this.txtVal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVal.ForeColor = System.Drawing.Color.Red;
            this.txtVal.Location = new System.Drawing.Point(543, 26);
            this.txtVal.Multiline = true;
            this.txtVal.Name = "txtVal";
            this.txtVal.ReadOnly = true;
            this.txtVal.Size = new System.Drawing.Size(108, 26);
            this.txtVal.TabIndex = 3;
            this.txtVal.TabStop = false;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(436, 26);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(95, 25);
            this.lblValor.TabIndex = 2;
            this.lblValor.Text = "Valor R$";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(21, 26);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(344, 232);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 115;
            this.pictureBox2.TabStop = false;
            // 
            // txtPagamento
            // 
            this.txtPagamento.BackColor = System.Drawing.SystemColors.Control;
            this.txtPagamento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPagamento.ForeColor = System.Drawing.Color.Blue;
            this.txtPagamento.Location = new System.Drawing.Point(543, 85);
            this.txtPagamento.Multiline = true;
            this.txtPagamento.Name = "txtPagamento";
            this.txtPagamento.Size = new System.Drawing.Size(108, 26);
            this.txtPagamento.TabIndex = 0;
            // 
            // lblPagamento
            // 
            this.lblPagamento.AutoSize = true;
            this.lblPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagamento.Location = new System.Drawing.Point(436, 85);
            this.lblPagamento.Name = "lblPagamento";
            this.lblPagamento.Size = new System.Drawing.Size(94, 25);
            this.lblPagamento.TabIndex = 116;
            this.lblPagamento.Text = "Pgto. R$";
            // 
            // txtTroco
            // 
            this.txtTroco.BackColor = System.Drawing.SystemColors.Control;
            this.txtTroco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTroco.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTroco.Location = new System.Drawing.Point(543, 145);
            this.txtTroco.Multiline = true;
            this.txtTroco.Name = "txtTroco";
            this.txtTroco.ReadOnly = true;
            this.txtTroco.Size = new System.Drawing.Size(108, 26);
            this.txtTroco.TabIndex = 119;
            this.txtTroco.TabStop = false;
            // 
            // lblTroco
            // 
            this.lblTroco.AutoSize = true;
            this.lblTroco.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTroco.Location = new System.Drawing.Point(436, 145);
            this.lblTroco.Name = "lblTroco";
            this.lblTroco.Size = new System.Drawing.Size(100, 25);
            this.lblTroco.TabIndex = 118;
            this.lblTroco.Text = "Troco R$";
            // 
            // btnCalcula
            // 
            this.btnCalcula.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalcula.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcula.Location = new System.Drawing.Point(441, 208);
            this.btnCalcula.Name = "btnCalcula";
            this.btnCalcula.Size = new System.Drawing.Size(210, 30);
            this.btnCalcula.TabIndex = 1;
            this.btnCalcula.Text = "&Calcula";
            this.btnCalcula.UseVisualStyleBackColor = true;
            this.btnCalcula.Click += new System.EventHandler(this.btnCalcula_Click);
            // 
            // frmMoney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 284);
            this.Controls.Add(this.btnCalcula);
            this.Controls.Add(this.txtTroco);
            this.Controls.Add(this.lblTroco);
            this.Controls.Add(this.txtPagamento);
            this.Controls.Add(this.lblPagamento);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtVal);
            this.Controls.Add(this.lblValor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "frmMoney";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagamento em Espécie";
            this.Load += new System.EventHandler(this.frmMoney_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMoney_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVal;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtPagamento;
        private System.Windows.Forms.Label lblPagamento;
        private System.Windows.Forms.TextBox txtTroco;
        private System.Windows.Forms.Label lblTroco;
        private System.Windows.Forms.Button btnCalcula;
    }
}