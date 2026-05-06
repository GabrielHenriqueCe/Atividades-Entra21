using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Text;
namespace Aula_11_Poo
{
    internal class Produto
    {
        #region Propriedades

        public decimal Valor { get; set; }
        public string Nome { get; set; }

        #endregion

        #region Metodos

        public void ExibirInformacoes()
        {
            Console.WriteLine($"O produto {Nome} custa {Valor}.\n");
        }

        public static void ListarProdutos(Produto[] produtos)
        {
            Console.WriteLine("\n==== LISTA DE PRODUTOS ====");
            if (produtos[0] == null)
            {
                Console.WriteLine("Nenhum produto cadastrado.");
                return;
            }
            foreach (Produto produto in produtos)
            {
                if (produto != null)
                {
                    Console.WriteLine($"Produto: {produto.Nome}, Valor: {produto.Valor}");
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine();
        }

        public static void ProdutoMaisCaro(Produto[] produtos)
        {
            Produto produtoMaisCaro = produtos[0];
            for (int i = 1; i < produtos.Length; i++)
            {
                if (produtos[i].Valor > produtoMaisCaro.Valor)
                {
                    produtoMaisCaro = produtos[i];
                }
            }
            Console.WriteLine($"\nO produto mais caro é: {produtoMaisCaro.Nome} com o valor de {produtoMaisCaro.Valor}.");
        }

        #endregion

        #region Atividades

        public static void Atividade1()
        {
            Produto[] produtos =
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

        public static void Atividade5()
        {
            Produto[] produtos = new Produto[3];
            int contador = 0;
            bool sair = false;
            while (!sair)
            {
                Console.WriteLine("\n==== MENU DE PRODUTOS ====");
                Console.WriteLine("1 - Cadastrar produto");
                Console.WriteLine("2 - Listar produtos");
                Console.WriteLine("3 - Sair");
                Console.Write("Escolha uma opção: ");
                string entrada = Console.ReadLine();
                switch (entrada)
                {
                    case "1":
                        Console.Clear();
                        if (contador == produtos.Length)
                        {
                            Console.OutputEncoding = System.Text.Encoding.UTF8;
                            Console.WriteLine("\n⚠️ ALERTA ⚠️");
                            Console.WriteLine("Limite de produtos cadastrados atingidos\n");
                            break;
                        }
                        Console.WriteLine("==== CADASTRO DE PRODUTOS ==== ");

                        Console.Write("Digite o nome do produto: ");
                        produtos[contador] = new Produto();
                        produtos[contador].Nome = Console.ReadLine();
                        while (string.IsNullOrEmpty(produtos[contador].Nome))
                        {
                            Console.Write("O nome do produto é obrigatório. Digite novamente: ");
                            produtos[contador].Nome = Console.ReadLine();
                        }
                        Console.Write("Digite o valor do produto: ");
                        string valorInput = Console.ReadLine();
                        decimal valor;
                        while (!decimal.TryParse(valorInput, out valor) || valor <= 0)
                        {
                            Console.Write("Valor inválido. Digite um valor numérico positivo: ");
                            valorInput = Console.ReadLine();
                        }
                        produtos[contador].Valor = valor;
                        contador++;

                        Program.PausaParaLer();
                        break;
                    case "2":
                        Console.Clear();
                        ListarProdutos(produtos);
                        Program.PausaParaLer();
                        break;
                    case "3":
                        sair = true;
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
                        break;
                }
            }
        }

        public static void Atividade7()
        {
            Produto[] produtos =
{
                new Produto() { Nome = "Notebook", Valor = 3000 },
                new Produto() { Nome = "Smartphone", Valor = 8000 },
                new Produto() { Nome = "Tablet", Valor = 1500 }
            };

            bool sair;
            do
            {
                Console.WriteLine("\n==== MENU DE PRODUTOS ====");
                Console.WriteLine("1 - Listar produtos");
                Console.WriteLine("2 - Exibir produto mais caro");
                Console.WriteLine("3 - Sair");
                Console.Write("Escolha uma opção: ");
                string entrada = Console.ReadLine();
                switch (entrada)
                {
                    case "1":
                        Console.Clear();
                        ListarProdutos(produtos);
                        sair = false;
                        Program.PausaParaLer();
                        break;
                    case "2":
                        Console.Clear();
                        ProdutoMaisCaro(produtos);
                        sair = false;
                        Program.PausaParaLer();
                        break;
                    case "3":
                        sair = true;
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
                        sair = false;
                        break;
                }
            } while (!sair);
        }
        #endregion
    }
}
