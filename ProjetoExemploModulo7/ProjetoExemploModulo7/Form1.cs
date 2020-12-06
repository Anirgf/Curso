﻿using ProjetoExemploModulo7.Transacao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoExemploModulo7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EntradaLivro entrada = new EntradaLivro();
            entrada.Codigo = 1;
            entrada.NumeroNota = 123;
            Livro meuLivro = new Livro();
            meuLivro.Codigo = 10;
            meuLivro.Editora.Codigo = 15;
            entrada.ListaLivros.Add(meuLivro);
            entrada.Fornecedor.Codigo = 12;
            entrada.Fornecedor.TipoPessoa = EnumTipoPessoa.Fornecedot;
            entrada.Fornecedor.EnderecoCompleto.Numero = 524;
            entrada.Fornecedor.EnderecoCompleto.Bairro.Cidade.Estado.Pais.Codigo = 50;

        }

        private void MostrarInformacoes(Pessoa pessoa)
        {
            if (typeof(Autor) == pessoa.GetType())
            {

            }
            else if (typeof(Cliente) == pessoa.GetType())
            {

            }
            else if (typeof(Editora) == pessoa.GetType())
            {

            }
            else if (typeof(Fornecedor) == pessoa.GetType())
            {

            }
        }
    }
}
