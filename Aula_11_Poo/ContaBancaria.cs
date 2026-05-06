using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_11_Poo
{
    internal class ContaBancaria
    {
        public decimal Valor { get; set; }
        public string Titular { get; set; }

        public void Depositar(string mensagem)
        {
            Console.WriteLine(mensagem);
            string valorInput = Console.ReadLine();
            decimal valor = 0;
            while (!decimal.TryParse(valorInput, out valor) || valor <= 0)
            {
                if (valor <= 0)
                {
                    Console.WriteLine("Valor inválido. Digite um número positivo:");
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Digite um número válido:");
                }
                Console.WriteLine(mensagem);
                valorInput = Console.ReadLine();
            }
            Valor += valor;
        }

        public void Sacar(string mensagem)
        {
            Console.WriteLine(mensagem);
            string valorInput = Console.ReadLine();
            decimal valor = 0;
            while (!decimal.TryParse(valorInput, out valor) || valor <= 0)
            {
                if (valor <= 0)
                {
                    Console.WriteLine("Valor inválido. Digite um número positivo:");
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Digite um número válido:");
                }
                if (valor > Valor)
                {
                    Console.WriteLine("Saldo insuficiente. Digite um valor menor ou igual ao saldo disponível:");
                }
                Console.WriteLine(mensagem);
                valorInput = Console.ReadLine();
            }
            Valor -= valor;
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"O titular {Titular} possui um saldo de {Valor:F2}.");
            Console.WriteLine();
        }

        public static void Atividade4()
        {
            ContaBancaria[] contas = new ContaBancaria[2];
            contas[0] = new ContaBancaria()
            {
                Titular = "João",
                Valor = 30000
            };

            bool sair = false;
            while (!sair)
            {
                Console.WriteLine("==== DIGITE UMA OPCAO ====");
                Console.WriteLine("1 - Depositar");
                Console.WriteLine("2 - Sacar");
                Console.WriteLine("3 - Sair");
                string opcao = Console.ReadLine();
                switch (opcao)
                {
                    case "1":
                        contas[0].Depositar($"Digite o valor a ser depositado na conta de {contas[0].Titular}:");
                        contas[0].ExibirInformacoes();
                        break;
                    case "2":
                        contas[0].Sacar($"Digite o valor a ser sacado da conta de {contas[0].Titular}:");
                        contas[0].ExibirInformacoes();
                        break;
                    case "3":
                        sair = true;
                        break;
                }
            }
        }

        public static void CadastrarConta(ContaBancaria[] contas, ref int contador)
        {
            Console.WriteLine("==== CADASTRO DE CONTA BANCARIA ==== ");
            if (contador >= contas.Length)
            {
                Console.WriteLine("Limite de contas atingido. Não é possível cadastrar mais contas.");
                return;
            }
            for (int i = 0; i < contas.Length; i++)
            {
                Console.Write("Digite o nome do titular da conta: ");
                contas[contador] = new ContaBancaria();
                contas[contador].Titular = Console.ReadLine();
                while (string.IsNullOrWhiteSpace(contas[contador].Titular))
                {
                    Console.WriteLine("Nome do titular não pode ser vazio. Digite novamente:");
                    contas[contador].Titular = Console.ReadLine();
                }
                contas[contador].Valor = 0;
                contador++;
            }
        }
        public static void Atividade9()
        {
            ContaBancaria[] contas = new ContaBancaria[1];
            int contador = 0;
            int indiceConta = 0;
            bool sair = false;
            while (!sair)
            {
                Console.WriteLine("==== DIGITE UMA OPCAO ====");
                Console.WriteLine("1 - Criar Conta");
                Console.WriteLine("2 - Depositar");
                Console.WriteLine("3 - Sacar");
                Console.WriteLine("4 - Exibir Saldo");
                Console.WriteLine("5 - Sair");
                string opcao = Console.ReadLine();
                switch (opcao)
                {
                    case "1":
                        CadastrarConta(contas, ref contador);
                        break;
                    case "2":
                        contas[indiceConta].Depositar($"Digite o valor a ser depositado na conta de {contas[indiceConta].Titular}:");
                        break;
                    case "3":
                        contas[indiceConta].Sacar($"Digite o valor a ser sacado da conta de {contas[indiceConta].Titular}:");
                        break;
                    case "4":
                        contas[indiceConta].ExibirInformacoes();
                        break;
                    case "5":
                        sair = true;
                        break;
                }
            }
        }
    }
}

