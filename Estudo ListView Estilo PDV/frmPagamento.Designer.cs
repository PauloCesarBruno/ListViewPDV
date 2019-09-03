namespace Estudo_ListView_Estilo_PDV
{
    partial class frmPagamento
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
            this.lblValor = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFormapg = new System.Windows.Forms.Label();
            this.rbDinheiro = new System.Windows.Forms.RadioButton();
            this.rbDébito = new System.Windows.Forms.RadioButton();
            this.rbCredito = new System.Windows.Forms.RadioButton();
            this.rbCheque = new System.Windows.Forms.RadioButton();
            this.rbMarcacao = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(5, 13);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(95, 25);
            this.lblValor.TabIndex = 0;
            this.lblValor.Text = "Valor R$";
            // 
            // txtValor
            // 
            this.txtValor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtValor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(99, 13);
            this.txtValor.Multiline = true;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(135, 26);
            this.txtValor.TabIndex = 1;
            this.txtValor.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(-4, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 17);
            this.panel1.TabIndex = 2;
            // 
            // lblFormapg
            // 
            this.lblFormapg.AutoSize = true;
            this.lblFormapg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormapg.Location = new System.Drawing.Point(3, 88);
            this.lblFormapg.Name = "lblFormapg";
            this.lblFormapg.Size = new System.Drawing.Size(130, 13);
            this.lblFormapg.TabIndex = 3;
            this.lblFormapg.Text = "Forma de Pagamento:";
            // 
            // rbDinheiro
            // 
            this.rbDinheiro.AutoSize = true;
            this.rbDinheiro.Location = new System.Drawing.Point(12, 130);
            this.rbDinheiro.Name = "rbDinheiro";
            this.rbDinheiro.Size = new System.Drawing.Size(63, 17);
            this.rbDinheiro.TabIndex = 4;
            this.rbDinheiro.Text = "&Espécie";
            this.rbDinheiro.UseVisualStyleBackColor = true;
            this.rbDinheiro.CheckedChanged += new System.EventHandler(this.rbDinheiro_CheckedChanged);
            // 
            // rbDébito
            // 
            this.rbDébito.AutoSize = true;
            this.rbDébito.Location = new System.Drawing.Point(86, 130);
            this.rbDébito.Name = "rbDébito";
            this.rbDébito.Size = new System.Drawing.Size(56, 17);
            this.rbDébito.TabIndex = 5;
            this.rbDébito.Text = "&Débito";
            this.rbDébito.UseVisualStyleBackColor = true;
            // 
            // rbCredito
            // 
            this.rbCredito.AutoSize = true;
            this.rbCredito.Location = new System.Drawing.Point(152, 130);
            this.rbCredito.Name = "rbCredito";
            this.rbCredito.Size = new System.Drawing.Size(58, 17);
            this.rbCredito.TabIndex = 6;
            this.rbCredito.Text = "&Crédito";
            this.rbCredito.UseVisualStyleBackColor = true;
            // 
            // rbCheque
            // 
            this.rbCheque.AutoSize = true;
            this.rbCheque.Location = new System.Drawing.Point(220, 130);
            this.rbCheque.Name = "rbCheque";
            this.rbCheque.Size = new System.Drawing.Size(62, 17);
            this.rbCheque.TabIndex = 7;
            this.rbCheque.Text = "&Cheque";
            this.rbCheque.UseVisualStyleBackColor = true;
            // 
            // rbMarcacao
            // 
            this.rbMarcacao.AutoSize = true;
            this.rbMarcacao.Checked = true;
            this.rbMarcacao.Location = new System.Drawing.Point(99, 153);
            this.rbMarcacao.Name = "rbMarcacao";
            this.rbMarcacao.Size = new System.Drawing.Size(183, 17);
            this.rbMarcacao.TabIndex = 8;
            this.rbMarcacao.TabStop = true;
            this.rbMarcacao.Text = "Só Serve para aparecer Marcado";
            this.rbMarcacao.UseVisualStyleBackColor = true;
            this.rbMarcacao.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "F1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(108, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "F2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(174, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "F3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(242, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "F4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Invisivel ->>";
            this.label5.Visible = false;
            // 
            // frmPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(295, 172);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbMarcacao);
            this.Controls.Add(this.rbCheque);
            this.Controls.Add(this.rbCredito);
            this.Controls.Add(this.rbDébito);
            this.Controls.Add(this.rbDinheiro);
            this.Controls.Add(this.lblFormapg);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblValor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "frmPagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forma de Pagamento";
            this.Load += new System.EventHandler(this.frmPagamento_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPagamento_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblFormapg;
        private System.Windows.Forms.RadioButton rbDinheiro;
        private System.Windows.Forms.RadioButton rbDébito;
        private System.Windows.Forms.RadioButton rbCredito;
        private System.Windows.Forms.RadioButton rbCheque;
        private System.Windows.Forms.RadioButton rbMarcacao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}