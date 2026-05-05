using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_11_Poo
{
    internal class Produto
    {
        public decimal Valor { get; set; }
        public string Nome { get; set; }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"O produto {Nome} custa {Valor}.");
            Console.WriteLine();
        }

        public static void Atividade1()
        {
            Produto[] produtos = new Produto[]
            {
                new Produto() { Nome = "Notebook", Valor = 3000 },
                new Produto() { Nome = "Smartphone", Valor = 8000 },
                new Produto() { Nome = "Tablet", Valor = 1500 }
            };


            for (int i = 0; i < produtos.Length; i++)
            {
                produtos[i].ExibirInformacoes();
            }
        }
    }
}
