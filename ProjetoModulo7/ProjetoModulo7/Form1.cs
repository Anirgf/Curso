using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 

namespace ProjetoModulo7
{
    public partial class Form1 : Form
    {
        private Carro meuCarro;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            meuCarro = new Carro();
            meuCarro.cor = "Azul";
            meuCarro.qtdPortas = 2;
            ConverterparaString(meuCarro);
            MessageBox.Show(meuCarro.cor);

            Motocicleta minhaMoto = new Motocicleta();
            minhaMoto.cor = "Prata";
            MessageBox.Show(minhaMoto.cor);
            ConverterparaString(minhaMoto);
                       
        }

        public string ConverterparaString(IVeiculo veiculo)
        {
            if (typeof(IVeiculo) == veiculo.GetType())
            {
                return "Veiculo cor: " + veiculo.cor;
            }

            else if (typeof(Carro) == veiculo.GetType())
            {
                return "Carro cor: " + veiculo.cor;
            }

            else if (typeof(Motocicleta) == veiculo.GetType())
            {
                return "Motocicleta cor: " + veiculo.cor;
            }
            return string.Empty;
        }

        private void btnLigar_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer Player = new System.Media.SoundPlayer("C:/Users/Suporte KTI SW/source/repos/ProjetoModulo7/ProjetoModulo7/bin/Debug/Ligar 113.wav");
            Player.Play();
            MessageBox.Show(meuCarro.Ligar());
        }

        private void btnAcelerar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(meuCarro.Acelerar());
        }
    }
}
