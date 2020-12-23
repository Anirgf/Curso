using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoModulo4
{
    public partial class FormEstruturasRepeticao : Form
    {
        private List<int> lista = new List<int>();

        public FormEstruturasRepeticao()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim().Equals(String.Empty))
            {
                MessageBox.Show("Voce devera digitar algum valor", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
                return;
            }
            int iValorlido = Convert.ToInt32(textBox1.Text.Trim());
            int i = 0;
            listView1.Items.Clear();
            /*for (int i = 0; i <= 10; i++)
            {
                ListViewItem itmx = listView1.Items.Add(iValorlido.ToString());
                itmx.SubItems.Add(new ListViewItem.ListViewSubItem(null, "*"));
                itmx.SubItems.Add(new ListViewItem.ListViewSubItem(null, i.ToString()));
                itmx.SubItems.Add(new ListViewItem.ListViewSubItem(null, "="));
                itmx.SubItems.Add(new ListViewItem.ListViewSubItem(null, (iValorlido * i).ToString()));

            }*/
            /*while (i <=10)
            {
                ListViewItem itmx = listView1.Items.Add(iValorlido.ToString());
                itmx.SubItems.Add(new ListViewItem.ListViewSubItem(null, "*"));
                itmx.SubItems.Add(new ListViewItem.ListViewSubItem(null, i.ToString()));
                itmx.SubItems.Add(new ListViewItem.ListViewSubItem(null, "="));
                itmx.SubItems.Add(new ListViewItem.ListViewSubItem(null, (iValorlido * i).ToString()));
                i++;
            }*/
            do
            {
                ListViewItem itmx = listView1.Items.Add(iValorlido.ToString());
                itmx.SubItems.Add(new ListViewItem.ListViewSubItem(null, "*"));
                itmx.SubItems.Add(new ListViewItem.ListViewSubItem(null, i.ToString()));
                itmx.SubItems.Add(new ListViewItem.ListViewSubItem(null, "="));
                itmx.SubItems.Add(new ListViewItem.ListViewSubItem(null, (iValorlido * i).ToString()));
                i++;
            } while (i <= 10);

            //Trabalhando com Vetores = sequencia de elementos
            int[] vetor;

            //Trabalhando com Matrizes
            int[,] matriz;
            int soma = 0;
            /*
            matriz = new int[3, 2];
            matriz[0, 1] = 10;
            matriz[0, 2] = 20;
            matriz[1, 0] = 30;
            matriz[1, 1] = 40;
            matriz[2, 0] = 50;
            matriz[2, 1] = 60;
            */
            matriz = new int[,] { { 10, 10, 10 }, { 25, 30, 40 } };
            for (int linha = 0; linha < 2; linha++)
            {
                for (int coluna = 0; coluna < 3; coluna++)
                {
                    soma = soma + matriz[linha, coluna];
                }
            }
        }

        private void FormEstruturasRepeticao_Load(object sender, EventArgs e)
        {
            int i = 0;
            listView1.Clear();

            listView1.Columns.Insert(0, "Valor", 100, HorizontalAlignment.Center);
            listView1.Columns.Insert(1, "sinal", 100, HorizontalAlignment.Center);
            listView1.Columns.Insert(2, "Valor", 100, HorizontalAlignment.Center);
            listView1.Columns.Insert(3, "igual", 100, HorizontalAlignment.Center);
            listView1.Columns.Insert(4, "resultado", 100, HorizontalAlignment.Center);

            /*for (int i = 0; i <= 100; i++)
            {
                comboBox1.Items.Add(i.ToString());
            }*/
            do
            {
                comboBox1.Items.Add(i.ToString());
                i++;
            } while (i <= 100);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Trim().Equals(String.Empty))
            {
                MessageBox.Show("Voce deve informar um valor!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Focus();
                return;
            }
            lista.Add(Convert.ToInt32(textBox2.Text.Trim()));
            listBox1.Items.Add(textBox2.Text.Trim());
            textBox2.Text = String.Empty;
            textBox2.Focus();
                
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (String item in listBox1.Items)
            {
                listBox2.Items.Add(item.ToString());
            }
        }
    }
}
