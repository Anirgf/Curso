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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Primeira Forma
            //MessageBox.Show(System.Environment.CurrentDirectory);

            //Segunda Forma
            MessageBox.Show(System.AppDomain.CurrentDomain.BaseDirectory);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String nomeArq = @"C:\Users\Suporte KTI SW\source\repos\Anirgf\Curso\ProjetoModulo5\ProjetoModulo5\bin\Debug\Arquivo.txt";
            if (File.Exists(nomeArq))
            {
                MessageBox.Show("Arquivo existe");
            }
            else
            { 
                MessageBox.Show("Arquivo não existe");
                Stream arquivo = File.Create(nomeArq);
                arquivo.Close();
            }

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String nomeArq = @"C:\Users\Suporte KTI SW\source\repos\Anirgf\Curso\ProjetoModulo5\bin\Debug\Arquivo.txt";
            if (File.Exists(nomeArq))
            {
                MessageBox.Show("Arquivo existe");
                File.Delete(nomeArq);
            }
            else
            {
                MessageBox.Show("Arquivo não existe");
                
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String nomePasta = @"C:\Users\Suporte KTI SW\source\repos\Anirgf\Curso\ProjetoModulo5\bin\Debug\Exemplo";
            String nomeArq = nomePasta + @"\PrimeiroExemplo.txt";
            if (!Directory.Exists(nomePasta))
            {
                Directory.CreateDirectory(nomePasta);
            }
            if (!File.Exists(nomeArq))
            {
                File.Create(nomeArq);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!texNomePasta.Text.Trim().Equals(String.Empty))
            {
                String nomePasta = @"C:\Users\Suporte KTI SW\source\repos\Anirgf\Curso\ProjetoModulo5\bin\Debug\Exemplo";
                String nomeArq = nomePasta + @"\PrimeiroExemplo.txt";
                if (Directory.Exists(nomePasta))
                {
                    Directory.Move(nomePasta, texNomePasta.Text.Trim());
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!texNomeArquivo.Text.Trim().Equals(String.Empty))
            {
                String nomePasta = @"C:\Users\Suporte KTI SW\source\repos\Anirgf\Curso\ProjetoModulo5\bin\Debug\Exemplo";
                String nomeArq = nomePasta + @"\PrimeiroExemplo.txt";
                if (File.Exists(nomePasta))
                {
                    File.Move(nomeArq, nomePasta + @"\" + texNomeArquivo.Text.Trim());
                }
            }
        }
    }
}
