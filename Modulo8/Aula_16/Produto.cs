using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_16
{
    internal class Produto
    {
        public string Nome { get; private set; }
        public double Preco { get; private set; }
        public string Categoria { get; private set; }
        public int Estoque { get; private set; }


        public Produto (string nome, double preco, string categoria = null, int estoque = 0)
        {
            Nome = nome;
            Preco = preco;
            Categoria = categoria;
            Estoque = estoque;
        }
    }
}
