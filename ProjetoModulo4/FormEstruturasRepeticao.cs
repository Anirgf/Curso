﻿using System;
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
            int iPrimeirovalor;
            int soma = 0;
            int index;
            /*
            vetor = new int[10];
            vetor[0] = 20;
            vetor[1] = 50;
            vetor[2] = 59;
            vetor[3] = 61;
            vetor[4] = 75;
            vetor[5] = 79;
            vetor[6] = 81;
            vetor[7] = 88;
            vetor[8] = 93;
            vetor[9] = 95;
            */
            vetor = new int[] { 10, 20, 30, 40, 50 };
            iPrimeirovalor = vetor[0];
            for (index = 0; index < vetor.Length; index++)
            {
                soma = soma + vetor[index];
            }

            /*index = 0;
            while ( index < vetor.Length)
            {
                soma = soma + vetor[index];
                index++;
            }

            index = 0;
            do
            {
                soma = soma + vetor[index];
                index++;
            } while (index < vetor.Length);
            */
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
