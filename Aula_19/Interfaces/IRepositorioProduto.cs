using Aula_19.Excecoes;
using Aula_19.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_19.Interfaces
{
    internal interface IRepositorioProduto
    {
        void Adicionar(Produto p);
        List<Produto> ListarTodos();
        List<Produto> BuscarPorCategoria(string categoria);
        Produto BuscarPorId(int id);
    }
}
