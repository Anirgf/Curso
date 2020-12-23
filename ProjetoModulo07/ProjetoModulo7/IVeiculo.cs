using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModulo7
{
    public interface IVeiculo
    {
         string cor { get; set; }
         string modelo { get; set; }
         double velocidadeMaxima { get; set; }
         int qtdRodas { get; set; }
         int qtdPortas { get; set; }

         string Ligar();

         string Ligar(int velocidade);

         string Ligar(double vel);

         string Acelerar();

    }
}
