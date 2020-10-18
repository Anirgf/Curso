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
            this.button1 = new System.Windows.Forms.Button();
            this.btnLeitura3 = new System.Windows.Forms.Button();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnLeitura
            // 
            this.btnLeitura.Location = new System.Drawing.Point(12, 42);
            this.btnLeitura.Name = "btnLeitura";
            this.btnLeitura.Size = new System.Drawing.Size(169, 46);
            this.btnLeitura.TabIndex = 0;
            this.btnLeitura.Text = "1 - Realizar Leitura";
            this.btnLeitura.UseVisualStyleBackColor = true;
            this.btnLeitura.Click += new System.EventHandler(this.btnLeitura_Click);
            // 
            // lsbConteudo
            // 
            this.lsbConteudo.FormattingEnabled = true;
            this.lsbConteudo.Location = new System.Drawing.Point(12, 108);
            this.lsbConteudo.Name = "lsbConteudo";
            this.lsbConteudo.Size = new System.Drawing.Size(665, 264);
            this.lsbConteudo.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(185, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 46);
            this.button1.TabIndex = 2;
            this.button1.Text = "2 -  Realizar Leitura";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLeitura3
            // 
            this.btnLeitura3.Location = new System.Drawing.Point(351, 42);
            this.btnLeitura3.Name = "btnLeitura3";
            this.btnLeitura3.Size = new System.Drawing.Size(160, 46);
            this.btnLeitura3.TabIndex = 3;
            this.btnLeitura3.Text = "3 -  Realizar Leitura";
            this.btnLeitura3.UseVisualStyleBackColor = true;
            this.btnLeitura3.Click += new System.EventHandler(this.btnLeitura3_Click);
            // 
            // btnProcurar
            // 
            this.btnProcurar.Location = new System.Drawing.Point(517, 42);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(160, 46);
            this.btnProcurar.TabIndex = 4;
            this.btnProcurar.Text = "Procurar Arquivo";
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // openFile
            // 
            this.openFile.DefaultExt = "txt";
            this.openFile.Title = "Selecionar Arquivo";
            // 
            // FrmLeituraArquivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 388);
            this.Controls.Add(this.btnProcurar);
            this.Controls.Add(this.btnLeitura3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lsbConteudo);
            this.Controls.Add(this.btnLeitura);
            this.Name = "FrmLeituraArquivo";
            this.Text = "FrmLeituraArquivo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLeitura;
        private System.Windows.Forms.ListBox lsbConteudo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLeitura3;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.OpenFileDialog openFile;
    }
}