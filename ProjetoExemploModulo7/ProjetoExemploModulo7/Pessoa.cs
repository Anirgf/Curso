using ProjetoExemploModulo7.Endereco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoExemploModulo7
{
    public abstract class Pessoa : Entidade
    {
        public Pessoa()
        {
            this.EnderecoCompleto = new EnderecoCompleto();
        }
        public string CPF { get; set; }
        public string CNPJ { get; set; }
        public EnumTipoPessoa TipoPessoa { get; set; }
        public EnderecoCompleto EnderecoCompleto { get; set; }
    }
}
