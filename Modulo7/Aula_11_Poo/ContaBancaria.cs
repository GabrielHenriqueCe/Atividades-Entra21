using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_11_Poo
{
    internal class ContaBancaria
    {
        #region Propriedades
        public decimal Valor { get; set; }
        public string Titular { get; set; }

        #endregion

        #region Metodos

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
            while (!decimal.TryParse(valorInput, out valor) || valor <= 0 || valor > Valor)
            {
                if (!decimal.TryParse(valorInput, out valor))
                {
                    Console.WriteLine("Entrada inválida. Digite um número válido:");
                }
                else if (valor <= 0)
                {
                    Console.WriteLine("Valor inválido. Digite um número positivo:");
                }
                else if (valor > Valor)
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

        #endregion

    }
}

