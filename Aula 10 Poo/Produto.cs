using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_10_Poo
{
    class Produto
    {
        public decimal Valor { get; set; }
        public string Nome { get; set; }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"O produto {Nome} custa {Valor}.");
            Console.WriteLine();
        }

        public static void Atividade3()
        {
            Produto[] produtos = new Produto[2];
            produtos[0] = new Produto()
            {
                Nome = "Notebook",
                Valor = 3000
            };
            produtos[1] = new Produto()
            {
                Nome = "Smartphone",
                Valor = 8000
            };

            for (int i = 0; i < produtos.Length; i++)
            {
                produtos[i].ExibirInformacoes();
            }
        }
    }
}
