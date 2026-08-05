using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_13
{
    internal class ContaPoupanca : Conta
    {
        public double TaxaRendimento { get; set; }
        public override void TipoDescricao()
        {
            Saldo *= TaxaRendimento;
            Console.WriteLine($"Seu Saldo é de R${Saldo:F2}");
        }
    }
}
