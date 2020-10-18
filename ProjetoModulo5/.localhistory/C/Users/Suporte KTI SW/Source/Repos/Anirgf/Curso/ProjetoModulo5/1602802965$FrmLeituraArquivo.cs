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
            string nomeArq = @"C:\Exemplo\Arquivo.txt";
            if(File.Exists(nomeArq))
            if(File.Exists(nomeArq))
            if(File.Exists(nomeArq))
            if(File.Exists(nomeArq))
            {
                String[] array = File.ReadAllLines(nomeArq);
                lsbConteudo.Items.Clear();
                foreach (var item in array)
                {
                    lsbConteudo.Items.Add(item);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String nomeArq = @"C:\Exemplo\Arquivo.txt";
            if (File.Exists(nomeArq))
            {
                StreamReader reader = new StreamReader(nomeArq);
                String linha;
                lsbConteudo.Items.Clear();
                while ((linha = reader.ReadLine()) != null)
                {
                    lsbConteudo.Items.Add(linha);
                }
                reader.Close();
            }
        }

        private void btnLeitura3_Click(object sender, EventArgs e)
        {
            String nomeArq = @"C:\Exemplo\Arquivo.txt";
            if (File.Exists(nomeArq))
            {
                StreamReader reader = File.OpenText(nomeArq);
                lsbConteudo.Items.Clear();s
                while (!reader.EndOfStream)
                {
                    String linha = reader.ReadLine();
                    lsbConteudo.Items.Add(linha);
                }
                reader.Close();
            }
        }
    }
}
