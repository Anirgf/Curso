using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoModulo5
{
    public partial class FrmLeituraArquivo : Form
    {
        public FrmLeituraArquivo()
        {
            InitializeComponent();
        }

        private void btnLeitura_Click(object sender, EventArgs e)
        {
            String nomeArq = @"C:\Users\Suporte KTI SW\source\repos\Anirgf\Curso\ProjetoModulo5\bin\Debug\Nova Pasta\Arquivo.txt";
            if (File.Exists(nomeArq))
            {
                String[] array = File.ReadAllLines(nomeArq);
                foreach (var item in array)
                {
                    lsbConteudo.Items.Add(item);
                }
            }
        }
    }
}
