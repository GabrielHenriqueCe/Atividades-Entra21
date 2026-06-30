using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Channels;

namespace Aula_17
{
    internal class Atividades
    {
        public static void At1()
        {
            Console.Write("Digite um número: ");
            string entrada = Console.ReadLine();
            try
            {
                int saida = int.Parse(entrada);
            }

            catch (FormatException ex)
            {
                Console.WriteLine($"Digite apenas números Inteiros! {ex.Message}");
            }
        }

        public static void At2()
        {
            Console.Write("Digite um número: ");
            string entrada = Console.ReadLine();

            Console.Write("Digite outro número: ");
            string entradaDnv = Console.ReadLine();

            try
            {
                int saida = int.Parse(entrada);
                int saidaDnv = int.Parse(entradaDnv);

                CalcularOperacao(saida, saidaDnv);
            }

            catch (FormatException ex)
            {
                Console.WriteLine($"Digite apenas números Inteiros! {ex.Message}");
            }

            catch (DivideByZeroException)
            {
                Console.WriteLine($"O número não pode ser divisível por Zero");
            }

            finally
            {
                Console.WriteLine("Operação finalizada!");
            }
        }

        public static void CalcularOperacao(int valor1, int valor2)
        {
            int resultado = valor1 / valor2;
            Console.WriteLine($"Resultado da operação é {resultado}");
        }

        public static void At3()
        {
            const int cem = 100;
            Console.Write("Digite um número: ");
            string entrada = Console.ReadLine();

            try
            {
                int saida = int.Parse(entrada);

                CalcularOperacao(cem, saida);
            }

            catch (DivideByZeroException)
            {
                Console.WriteLine("O número não pode ser divisível por Zero");
            }

            catch (FormatException ex)
            {
                Console.WriteLine($"Digite apenas números Inteiros! {ex.Message}");
            }

            catch (OverflowException)
            {
                Console.WriteLine("Número muito grande!");
            }

            catch (Exception ex)
            {
                Console.WriteLine($"Erro inesperado > {ex}");
            }
        }
        static void CadastrarPessoa(string nome, int idade)
        {
            if (idade < 0 || idade > 150)
                throw new IdadeInvalidaException(idade);

            Console.WriteLine($"Pessoa cadastrada: {nome}, {idade} anos");
        }

        public static void At4()
        {
            Console.Write("Digite o nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite a idade: ");
            string entrada = Console.ReadLine();

            try
            {
                int idade = int.Parse(entrada);
                CadastrarPessoa(nome, idade);
            }
            catch (IdadeInvalidaException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void At5()
        {
            double saida1;
            double saida2;

            Console.Write("Digite o primeiro número: ");
            string entrada1 = Console.ReadLine();
            while (!double.TryParse(entrada1, out saida1))
            {
                Console.Write("Entrada inválida! Digite um número: ");
                entrada1 = Console.ReadLine();
            }

            Console.Write("Digite a operação: ");
            string simbolo = Console.ReadLine();
            while (simbolo != "*" && simbolo != "/" && simbolo != "+" && simbolo != "-")
            {
                Console.Write("Operação inválida! Digite a operação: ");
                simbolo = Console.ReadLine();
            }

            Console.Write("Digite o segundo número: ");
            string entrada2 = Console.ReadLine();
            while (!double.TryParse(entrada2, out saida2))
            {
                Console.WriteLine("Entrada inválida! Digite um número");
                entrada2 = Console.ReadLine();
            }

            double resultado = 0;
            switch (simbolo)
            {
                case "+":
                    resultado = saida1 + saida2;
                    break;
                case "-":
                    resultado = saida1 - saida2;
                    break;
                case "*":
                    resultado = saida1 * saida2;
                    break;
                case "/":
                    resultado = saida1 / saida2;
                    break;
            }

            Console.WriteLine($"O resultado da operação {simbolo} é: {resultado}");

        }

        public static void AtExtra()
        {
            ContaBancaria novaConta = new ContaBancaria("Gabriel", 0);
            bool sair = false;
            while (!sair)
            {
                Console.WriteLine("1 - Sacar");
                Console.WriteLine("2 - Depositar");
                Console.WriteLine("x - Sair");
                string entrada = Console.ReadLine();
                switch (entrada)
                {
                    case "1":
                        Console.Write("Digite o valor que deseja Sacar: ");
                        string entradaSaque = Console.ReadLine();

                        try
                        {
                            decimal saque = decimal.Parse(entradaSaque);
                            novaConta.Sacar(saque);
                            Console.WriteLine($"Saque de R$ {saque:F2} realizado. Saldo: R$ {novaConta.Saldo:F2}");
                        }
                        catch (SaldoInsuficienteException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        catch (ValorInvalidoException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"ERRO!: { ex.Message}");
                        }
                        break;
                    case "2":
                        Console.Write("Digite o valor que deseja Depositar: ");
                        string entradaDeposito = Console.ReadLine();

                        try
                        {
                            decimal deposito = decimal.Parse(entradaDeposito);
                            novaConta.Depositar(deposito);
                            Console.WriteLine($"Saque de R$ {deposito:F2} realizado. Saldo: R$ {novaConta.Saldo:F2}");
                        }
                        catch (ValorInvalidoException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"ERRO!: {ex.Message}");
                        }
                        break;
                    case "x":
                        sair = true;
                        break;
                    default:
                        Console.WriteLine("Digite uma opção válida!");
                        break;
                }
            }
        }
    }
}
