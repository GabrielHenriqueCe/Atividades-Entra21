using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_14_Polimorfismo
{
    internal class Carro : Veiculo
    {
        public override void Mover()
        {
            Console.WriteLine($"{Tipo} acelerando na estrada");
        }
    }
}
