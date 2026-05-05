using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_10_Poo
{
    class ContaBancaria
    {
        public decimal Valor { get; set; }
        public string Titular { get; set; }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"O titular {Titular} possui um saldo de {Valor}.");
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
            contas[1] = new ContaBancaria()
            {
                Titular = "Maria",
                Valor = 80000
            };

            for (int i = 0; i < contas.Length; i++)
            {
                contas[i].ExibirInformacoes();
            }
        }
    }
}
