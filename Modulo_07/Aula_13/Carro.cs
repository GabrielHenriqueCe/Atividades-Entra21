using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_13
{
    internal class Carro : Veiculo
    {
        public int NumeroDePortas { get; set; }

        public Carro(int numeroDePortas, string marca, string modelo) : base(marca, modelo)
        {
            NumeroDePortas = numeroDePortas;
        }

        public override void ExibirInfo()
        {
            base.ExibirInfo();
            Console.WriteLine($"Numero de portas: {NumeroDePortas}");
        }
    }
}
