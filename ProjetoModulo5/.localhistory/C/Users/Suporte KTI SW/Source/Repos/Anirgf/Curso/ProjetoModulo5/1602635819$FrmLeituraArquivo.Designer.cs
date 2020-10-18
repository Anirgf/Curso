namespace ProjetoModulo5
{
    partial class FrmLeituraArquivo
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
            this.btnLeitura = new System.Windows.Forms.Button();
            this.lsbConteudo = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnLeitura
            // 
            this.btnLeitura.Location = new System.Drawing.Point(222, 57);
            this.btnLeitura.Name = "btnLeitura";
            this.btnLeitura.Size = new System.Drawing.Size(128, 23);
            this.btnLeitura.TabIndex = 0;
            this.btnLeitura.Text = "Realizar Leitura";
            this.btnLeitura.UseVisualStyleBackColor = true;
            this.btnLeitura.Click += new System.EventHandler(this.btnLeitura_Click);
            // 
            // lsbConteudo
            // 
            this.lsbConteudo.FormattingEnabled = true;
            this.lsbConteudo.Location = new System.Drawing.Point(12, 108);
            this.lsbConteudo.Name = "lsbConteudo";
            this.lsbConteudo.Size = new System.Drawing.Size(555, 264);
            this.lsbConteudo.TabIndex = 1;
            // 
            // FrmLeituraArquivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 388);
            this.Controls.Add(this.lsbConteudo);
            this.Controls.Add(this.btnLeitura);
            this.Name = "FrmLeituraArquivo";
            this.Text = "FrmLeituraArquivo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLeitura;
        private System.Windows.Forms.ListBox lsbConteudo;
    }
}