namespace WF_ClasseEventos
{
    partial class FrmWF_ClasseEventos
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
            this.LblValor = new System.Windows.Forms.Label();
            this.LblSaldo = new System.Windows.Forms.Label();
            this.TxtValor = new System.Windows.Forms.TextBox();
            this.TxtSaldo = new System.Windows.Forms.TextBox();
            this.BtnCredito = new System.Windows.Forms.Button();
            this.BtnDebito = new System.Windows.Forms.Button();
            this.TxtMensagens = new System.Windows.Forms.TextBox();
            this.TxtLinhas = new System.Windows.Forms.TextBox();
            this.LblLinhas = new System.Windows.Forms.Label();
            this.TxtTamanho = new System.Windows.Forms.TextBox();
            this.LblTamanho = new System.Windows.Forms.Label();
            this.gbxSobeOuDesce = new System.Windows.Forms.GroupBox();
            this.rbtDesce = new System.Windows.Forms.RadioButton();
            this.rbtSobe = new System.Windows.Forms.RadioButton();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.gbxSobeOuDesce.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblValor
            // 
            this.LblValor.AutoSize = true;
            this.LblValor.Location = new System.Drawing.Point(12, 12);
            this.LblValor.Name = "LblValor";
            this.LblValor.Size = new System.Drawing.Size(34, 13);
            this.LblValor.TabIndex = 0;
            this.LblValor.Text = "Valor:";
            // 
            // LblSaldo
            // 
            this.LblSaldo.AutoSize = true;
            this.LblSaldo.Location = new System.Drawing.Point(16, 51);
            this.LblSaldo.Name = "LblSaldo";
            this.LblSaldo.Size = new System.Drawing.Size(37, 13);
            this.LblSaldo.TabIndex = 2;
            this.LblSaldo.Text = "Saldo:";
            // 
            // TxtValor
            // 
            this.TxtValor.Location = new System.Drawing.Point(18, 28);
            this.TxtValor.Name = "TxtValor";
            this.TxtValor.Size = new System.Drawing.Size(144, 20);
            this.TxtValor.TabIndex = 1;
            this.TxtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtValor_KeyPress);
            // 
            // TxtSaldo
            // 
            this.TxtSaldo.Location = new System.Drawing.Point(19, 67);
            this.TxtSaldo.Name = "TxtSaldo";
            this.TxtSaldo.ReadOnly = true;
            this.TxtSaldo.Size = new System.Drawing.Size(143, 20);
            this.TxtSaldo.TabIndex = 3;
            this.TxtSaldo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSaldo_KeyPress);
            // 
            // BtnCredito
            // 
            this.BtnCredito.Location = new System.Drawing.Point(17, 248);
            this.BtnCredito.Name = "BtnCredito";
            this.BtnCredito.Size = new System.Drawing.Size(145, 23);
            this.BtnCredito.TabIndex = 11;
            this.BtnCredito.Text = "&Crédito";
            this.BtnCredito.UseVisualStyleBackColor = true;
            this.BtnCredito.Click += new System.EventHandler(this.BtnCredito_Click);
            // 
            // BtnDebito
            // 
            this.BtnDebito.Location = new System.Drawing.Point(17, 277);
            this.BtnDebito.Name = "BtnDebito";
            this.BtnDebito.Size = new System.Drawing.Size(145, 23);
            this.BtnDebito.TabIndex = 12;
            this.BtnDebito.Text = "&Débito";
            this.BtnDebito.UseVisualStyleBackColor = true;
            this.BtnDebito.Click += new System.EventHandler(this.BtnDebito_Click);
            // 
            // TxtMensagens
            // 
            this.TxtMensagens.Location = new System.Drawing.Point(168, 12);
            this.TxtMensagens.Multiline = true;
            this.TxtMensagens.Name = "TxtMensagens";
            this.TxtMensagens.ReadOnly = true;
            this.TxtMensagens.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtMensagens.Size = new System.Drawing.Size(464, 317);
            this.TxtMensagens.TabIndex = 14;
            // 
            // TxtLinhas
            // 
            this.TxtLinhas.Location = new System.Drawing.Point(19, 106);
            this.TxtLinhas.Name = "TxtLinhas";
            this.TxtLinhas.ReadOnly = true;
            this.TxtLinhas.Size = new System.Drawing.Size(143, 20);
            this.TxtLinhas.TabIndex = 5;
            // 
            // LblLinhas
            // 
            this.LblLinhas.AutoSize = true;
            this.LblLinhas.Location = new System.Drawing.Point(16, 90);
            this.LblLinhas.Name = "LblLinhas";
            this.LblLinhas.Size = new System.Drawing.Size(41, 13);
            this.LblLinhas.TabIndex = 4;
            this.LblLinhas.Text = "Linhas:";
            // 
            // TxtTamanho
            // 
            this.TxtTamanho.Location = new System.Drawing.Point(19, 145);
            this.TxtTamanho.Name = "TxtTamanho";
            this.TxtTamanho.ReadOnly = true;
            this.TxtTamanho.Size = new System.Drawing.Size(143, 20);
            this.TxtTamanho.TabIndex = 7;
            // 
            // LblTamanho
            // 
            this.LblTamanho.AutoSize = true;
            this.LblTamanho.Location = new System.Drawing.Point(16, 129);
            this.LblTamanho.Name = "LblTamanho";
            this.LblTamanho.Size = new System.Drawing.Size(55, 13);
            this.LblTamanho.TabIndex = 6;
            this.LblTamanho.Text = "Tamanho:";
            // 
            // gbxSobeOuDesce
            // 
            this.gbxSobeOuDesce.Controls.Add(this.rbtDesce);
            this.gbxSobeOuDesce.Controls.Add(this.rbtSobe);
            this.gbxSobeOuDesce.Location = new System.Drawing.Point(19, 176);
            this.gbxSobeOuDesce.Name = "gbxSobeOuDesce";
            this.gbxSobeOuDesce.Size = new System.Drawing.Size(143, 66);
            this.gbxSobeOuDesce.TabIndex = 8;
            this.gbxSobeOuDesce.TabStop = false;
            this.gbxSobeOuDesce.Text = "Sobe ou Desce";
            // 
            // rbtDesce
            // 
            this.rbtDesce.AutoSize = true;
            this.rbtDesce.Location = new System.Drawing.Point(12, 42);
            this.rbtDesce.Name = "rbtDesce";
            this.rbtDesce.Size = new System.Drawing.Size(56, 17);
            this.rbtDesce.TabIndex = 10;
            this.rbtDesce.Text = "Desce";
            this.rbtDesce.UseVisualStyleBackColor = true;
            this.rbtDesce.CheckedChanged += new System.EventHandler(this.rbtDesce_CheckedChanged);
            // 
            // rbtSobe
            // 
            this.rbtSobe.AutoSize = true;
            this.rbtSobe.Checked = true;
            this.rbtSobe.Location = new System.Drawing.Point(12, 19);
            this.rbtSobe.Name = "rbtSobe";
            this.rbtSobe.Size = new System.Drawing.Size(50, 17);
            this.rbtSobe.TabIndex = 9;
            this.rbtSobe.TabStop = true;
            this.rbtSobe.Text = "Sobe";
            this.rbtSobe.UseVisualStyleBackColor = true;
            this.rbtSobe.CheckedChanged += new System.EventHandler(this.rbtSobe_CheckedChanged);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Location = new System.Drawing.Point(17, 306);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(145, 23);
            this.BtnLimpar.TabIndex = 13;
            this.BtnLimpar.Text = "&Limpar";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // FrmWF_ClasseEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 338);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.gbxSobeOuDesce);
            this.Controls.Add(this.TxtTamanho);
            this.Controls.Add(this.LblTamanho);
            this.Controls.Add(this.TxtLinhas);
            this.Controls.Add(this.LblLinhas);
            this.Controls.Add(this.TxtMensagens);
            this.Controls.Add(this.BtnDebito);
            this.Controls.Add(this.BtnCredito);
            this.Controls.Add(this.TxtSaldo);
            this.Controls.Add(this.TxtValor);
            this.Controls.Add(this.LblSaldo);
            this.Controls.Add(this.LblValor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmWF_ClasseEventos";
            this.ShowIcon = false;
            this.Text = "WF_ClasseEventos";
            this.Load += new System.EventHandler(this.FrmWF_ClasseEventos_Load);
            this.gbxSobeOuDesce.ResumeLayout(false);
            this.gbxSobeOuDesce.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblValor;
        private System.Windows.Forms.Label LblSaldo;
        private System.Windows.Forms.TextBox TxtValor;
        private System.Windows.Forms.TextBox TxtSaldo;
        private System.Windows.Forms.Button BtnCredito;
        private System.Windows.Forms.Button BtnDebito;
        private System.Windows.Forms.TextBox TxtMensagens;
        private System.Windows.Forms.TextBox TxtLinhas;
        private System.Windows.Forms.Label LblLinhas;
        private System.Windows.Forms.TextBox TxtTamanho;
        private System.Windows.Forms.Label LblTamanho;
        private System.Windows.Forms.GroupBox gbxSobeOuDesce;
        private System.Windows.Forms.RadioButton rbtDesce;
        private System.Windows.Forms.RadioButton rbtSobe;
        private System.Windows.Forms.Button BtnLimpar;
    }
}

