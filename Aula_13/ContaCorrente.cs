using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_13
{
    internal class ContaCorrente : Conta
    {
        public double TaxaManutencao {  get; set; }

        public override void TipoDescricao()
        {
            Saldo -= TaxaManutencao;
            Console.WriteLine($"Seu Saldo descontando a Taxa de: R${TaxaManutencao:F2} é de R${Saldo:F2}");
        }
    }
}
