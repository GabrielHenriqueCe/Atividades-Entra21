using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_11_Poo
{
    internal class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public bool ehMaior { get; set; }

        public bool EhMaior()
        {
            if (Idade >= 18)
            {
                Console.WriteLine($"O {Nome} é maior de idade.");
                ehMaior = true;
                return true;
            }
            else
            {
                Console.WriteLine($"O {Nome} é menor de idade.");
                ehMaior = false;
                return false;
            }
        }

        public void FornecerIdade(Pessoa[] pessoa, string mensagem)
        {
            Console.Write(mensagem);
            string idadeInput = Console.ReadLine();
            int idade = 0;
            while (!int.TryParse(idadeInput, out idade) || idade < 0)
            {
                if (idade < 0)
                {
                    Console.WriteLine("A idade não pode ser negativa. Por favor, digite um número válido para a idade.");
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, digite um número válido para a idade.");
                }
                Console.Write(mensagem);
                idadeInput = Console.ReadLine();
            }
            Idade = idade;
        }

        public void FornecerNome(Pessoa[] pessoa, string mensagem)
        {
            Console.Write(mensagem);
            string nomeInput = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(nomeInput))
            {
                Console.WriteLine("O nome não pode ser vazio. Por favor, digite um nome válido.");
                Console.Write(mensagem);
                nomeInput = Console.ReadLine();
            }
            Nome = nomeInput;
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"\nOlá, meu nome é {Nome} e tenho {Idade} anos.\n");
            EhMaior();
            Console.WriteLine();
        }

        public static void BuscarNome(Pessoa[] pessoa)
        {
            Console.Write("Digite o nome que deseja buscar: ");
            string nomeInput = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(nomeInput))
            {
                Console.WriteLine("O nome não pode ser vazio. Por favor, digite um nome válido.");
                return;
            }
            bool encontrado = pessoa.Any(p => p != null && p.Nome == nomeInput);
            if (encontrado)
            {
                Console.WriteLine($"\nO nome {nomeInput} foi encontrado.\n");
            }
            else
            {
                Console.WriteLine($"\nO nome {nomeInput} não foi encontrado.\n");
            }
        }

        public static void ListarNomes(Pessoa[] pessoas)
        {
            if (pessoas[0] == null)
            {
                Console.WriteLine("\nNenhuma pessoa cadastrada\n");
                return;
            }
            Console.WriteLine("\n==== LISTA DE PESSOAS ====");
            foreach (var pessoa in pessoas)
            {
                if (pessoa != null)
                {
                    Console.WriteLine($"Nome: {pessoa.Nome}, Idade: {pessoa.Idade}");
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine();
        }

        public static void CadastrarPessoa(Pessoa[] pessoa, ref int contador)
        {
            if (contador == pessoa.Length)
            {
                Console.OutputEncoding = System.Text.Encoding.UTF8;
                Console.WriteLine("\n⚠️ ALERTA ⚠️");
                Console.WriteLine("Limite de pessoas cadastradas atingidos\n");
                return;
            }

            Console.WriteLine("\n==== CADASTRO DE PESSOA ==== ");

            Pessoa novaPessoa = new Pessoa();
            novaPessoa.FornecerNome(pessoa, "Digite o nome da pessoa: ");
            novaPessoa.FornecerIdade(pessoa, "Digite a idade da pessoa: ");
            pessoa[contador] = novaPessoa;
            contador++;
        }

        public static void Atividade2()
        {
            Pessoa[] pessoa = { new Pessoa() };

            pessoa[0].FornecerNome(pessoa, "Digite o nome da pessoa: ");

            pessoa[0].FornecerIdade(pessoa, "Digite a idade da pessoa: ");


            for (int i = 0; i < pessoa.Length; i++)
            {
                if (pessoa[i] != null)
                {
                    pessoa[i].ExibirInformacoes();
                    Console.WriteLine();
                }
            }
        }

        public static void Atividade6()
        {
            Pessoa[] pessoa =
            {
                new Pessoa() { Nome = "Eduardo", Idade = 25 },
                new Pessoa() { Nome = "Ana", Idade = 17 },
                new Pessoa() { Nome = "Gabriel", Idade = 30 },
                new Pessoa() { Nome = "Jose", Idade = 15 },
                new Pessoa() { Nome = "Henrique", Idade = 22 }
            };

            bool sair;
            do
            {
                Console.WriteLine("==== MENU ====");
                Console.WriteLine("1. Listar Nomes");
                Console.WriteLine("2. Buscar Nome");
                Console.WriteLine("3. Sair");
                Console.Write("Escolha uma opção: ");
                string opcao = Console.ReadLine();
                switch (opcao)
                {
                    case "1":
                        ListarNomes(pessoa);
                        sair = false;
                        break;
                    case "2":
                        BuscarNome(pessoa);
                        sair = false;
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

        public static void Atividade10()
        {
            Pessoa[] pessoa = new Pessoa[5];
            int contador = 0;
            bool sair;
            do
            {
                Console.WriteLine("==== MENU ====");
                Console.WriteLine("1. Cadastrar Pessoa");
                Console.WriteLine("2. Listar Nomes");
                Console.WriteLine("3. Buscar Nome");
                Console.WriteLine("4. Sair");
                Console.Write("Escolha uma opção: ");
                string opcao = Console.ReadLine();
                switch (opcao)
                {
                    case "1":
                        CadastrarPessoa(pessoa, ref contador);
                        sair = false;
                        break;
                    case "2":
                        ListarNomes(pessoa);
                        sair = false;
                        break;
                    case "3":
                        BuscarNome(pessoa);
                        sair = false;
                        break;
                    case "4":
                        sair = true;
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
                        sair = false;
                        break;
                }
            } while (!sair);
        }
    }
}