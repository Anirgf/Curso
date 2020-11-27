using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoExemploModulo7.Endereco
{
    public class EnderecoCompleto
    {
        public EnderecoCompleto()
        {
            this.Bairro = new Bairro();
        }
        public int Numero { get; set; }
        public string Rua { get; set; }
        public Bairro Bairro { get; set; }
        public string LocalReferenci { get; set; }
    }
}
