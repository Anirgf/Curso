using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModulo7
{
    public class Motocicleta : IVeiculo
    {
        public string cor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string modelo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double velocidadeMaxima { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int qtdRodas { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int qtdPortas { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string Acelerar()
        {
            throw new NotImplementedException();
        }

        public string Ligar()
        {
            return "Motocicleta Ligada";
        }

        public string Ligar(int velocidade)
        {
            throw new NotImplementedException();
        }

        public string Ligar(double vel)
        {
            throw new NotImplementedException();
        }
    }
}
