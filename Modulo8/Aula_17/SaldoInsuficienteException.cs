using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_17
{
    internal class SaldoInsuficienteException : Exception
    {
        public SaldoInsuficienteException(decimal saldo, decimal saque)
    : base($"\nValor solicitado de R${saque:F2} é superior ao saldo Atual R${saldo:F2}\n") { }
    }
}
