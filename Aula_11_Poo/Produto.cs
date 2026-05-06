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
                Console.WriteLine("==== MENU DE PRODUTOS ====");
                Console.WriteLine("1 - Cadastrar produto");
                Console.WriteLine("2 - Listar produtos");
                Console.WriteLine("3 - Sair");
                Console.Write("Escolha uma opção: ");
                string entrada = Console.ReadLine();
                switch (entrada)
                {
                    case "1":
                        if(contador == produtos.Length)
                        {
                            Console.OutputEncoding = System.Text.Encoding.UTF8;
                            Console.WriteLine("\n⚠️ ALERTA ⚠️");
                            Console.WriteLine("Limite de produtos cadastrados atingidos\n");
                            break;
                        }
                        Console.WriteLine("==== CADASTRO DE PRODUTOS ==== ");
                        for (int i = 0; i < produtos.Length; i++)
                        {
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
                            break;
                        }
                        break;
                        case "2":
                        Console.WriteLine("==== LISTA DE PRODUTOS ====");
                        for (int i = 0; i < contador; i++)
                        {
                            produtos[i].ExibirInformacoes();
                        }
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
    }
}
