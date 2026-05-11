using System;
using System.Collections.Generic;
using System.Text;
using Utilities;
using static Utilities.Utils;

namespace Aula_12_Poo
{
    internal class Conta
    {
        #region Propriedades
        private decimal _saldo { get; set; }
        private decimal _saque { get; set; }
        private decimal _deposito { get; set; }

        public decimal Saldo
        {
            get { return _saldo; }
            set { _saldo = value; }
        }

        public decimal Saque
        {
            get { return _saque; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("O valor do saque não pode ser negativo.");
                }
                else if (value > Saldo)
                {
                    throw new ArgumentException("Saldo insuficiente para realizar o saque.");
                }
                else
                {
                    _saque = value;
                    Saldo -= value;
                }
            }
        }

        public decimal Deposito
        {
            get { return _deposito; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("O valor do depósito não pode ser negativo. Por favor, insira um valor válido.");
                }
                else
                {
                    _deposito = value;
                    Saldo += value;
                }
            }
        }

        #endregion

        #region Métodos

        public void ExibirSaldo()
        {
            Console.WriteLine($"O saldo atual é: R$ {Saldo:F2}");
        }

        //Action<decimal> é um delegate — basicamente você passa o que fazer com o valor como parâmetro.
        //O v => Saque = v é uma lambda que diz "pega o valor e atribui no Saque".
        private void RealizarOperacao(string mensagem, Action<decimal> operacao)
        {
            bool valido = false;
            while (!valido)
            {
                try
                {
                    Console.Write(mensagem);
                    decimal valor = decimal.Parse(Console.ReadLine());
                    operacao(valor);
                    valido = true;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Entrada inválida. Digite um número válido.");
                }
            }
        }

        public void Sacar()
        {
            RealizarOperacao("Digite o valor a ser sacado: R$ ", v => Saque = v);
        }

        public void Depositar()
        {
            RealizarOperacao("Digite o valor a ser depositado: R$ ", v => Deposito = v);
        }

        #endregion
    }
}
