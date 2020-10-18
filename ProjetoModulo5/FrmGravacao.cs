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
    public partial class FrmGravacao : Form
    {
        public FrmGravacao()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String nomeArq = @"D:\Exemplo\Arquivo.txt";
            {
                using (StreamWriter writer = new StreamWriter(nomeArq))
                {
                    writer.WriteLine("Primeiro conteúdo escrito");
                }
            }
        }
    }
}
