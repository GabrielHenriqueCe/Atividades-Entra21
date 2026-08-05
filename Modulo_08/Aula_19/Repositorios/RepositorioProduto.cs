using Aula_19.Excecoes;
using Aula_19.Interfaces;
using Aula_19.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_19.Repositorios
{
    internal class RepositorioProduto : IRepositorioProduto
    {
        private List<Produto> _produtos = new List<Produto>();

        public void Adicionar(Produto p)
        {
            _produtos.Add(p);
        }

        public List<Produto> ListarTodos()
        {
            return _produtos;
        }

        public List<Produto> BuscarPorCategoria(string categoria)
        {
            return _produtos.Where(p => p.Categoria == categoria).ToList();
        }

        public Produto BuscarPorId(int id)
        {
            return _produtos.FirstOrDefault(p => p.Id == id)
                ?? throw new ProdutoNaoEncontradoException(id);
        }
    }
}
