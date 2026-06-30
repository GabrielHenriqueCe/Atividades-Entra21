using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_17
{
    internal class ContaBancaria
    {
        public string Titular {  get; private set; }
        public decimal Saldo { get; set; }

        public ContaBancaria (string titular, decimal saldo)
        {
            Titular = titular;
            Saldo = saldo;
        }

        public void Sacar(decimal saque)
        {
            if (saque > Saldo)
                throw new SaldoInsuficienteException(Saldo, saque);
            else if (saque < 0)
                throw new ValorInvalidoException(saque);
            else
                Saldo-= saque;
        }

        public void Depositar (decimal deposito)
        {
            if (deposito < 0)
                throw new ValorInvalidoException(deposito);
            else
                Saldo += deposito;
        }
    }
}
