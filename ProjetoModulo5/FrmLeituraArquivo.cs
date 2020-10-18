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
            string nomeArq = @"D:\Exemplo\Arquivo.txt";
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
            String nomeArq = @"D:\Exemplo\Arquivo.txt";
            if (File.Exists(nomeArq))
            {
                //Primeira Forma
                //StreamReader reader = new StreamReader(nomeArq);
                //String linha;
                //lsbConteudo.Items.Clear();
                //while ((linha = reader.ReadLine()) != null)
                //{
                //    lsbConteudo.Items.Add(linha);
                //}
                //reader.Close();

                //Segunda Forma
                using (StreamReader reader = new StreamReader(nomeArq))
                {
                    String linha = reader.ReadLine();
                    lsbConteudo.Items.Clear();
                    while (linha != null)
                    {
                        lsbConteudo.Items.Add(linha);
                        linha = reader.ReadLine();
                    }
                }

            }
        }

        private void btnLeitura3_Click(object sender, EventArgs e)
        {
            String nomeArq = @"D:\Exemplo\Arquivo.txt";
            if (File.Exists(nomeArq))
            {
                //StreamReader reader = File.OpenText(nomeArq);
                //lsbConteudo.Items.Clear();
                //while (!reader.EndOfStream)
                //{
                //    String linha = reader.ReadLine();
                //    lsbConteudo.Items.Add(linha);
                //}
                //reader.Close();
                using(StreamReader reader = File.OpenText(nomeArq))
                {
                    lsbConteudo.Items.Clear();
                    while (!reader.EndOfStream)
                    {
                        String linha = reader.ReadLine();
                        lsbConteudo.Items.Add(linha);
                    }
                }
            }
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            string nomeArq;
            //OpenFileDialog openFile = new OpenFileDialog();
            //openFile.Title = "Selecionar Arquivo";
            //openFile.Multiselect = false;
            //openFile.CheckFileExists = true;
            //openFile.DefaultExt = "txt";
            //openFile.Filter = "Arquivo de Texto(*.txt)|*.txt";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                nomeArq = openFile.FileName;
                using (StreamReader reader = File.OpenText(nomeArq))
                {
                    string linha;
                    lsbConteudo.Items.Clear();
                    while ((linha = reader.ReadLine()) != null)
                    {
                        lsbConteudo.Items.Add(linha);
                    }
                }
            }

        }
    }
}
