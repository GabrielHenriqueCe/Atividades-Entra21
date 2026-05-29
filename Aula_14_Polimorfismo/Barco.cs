using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_14_Polimorfismo
{
    internal class Barco : Veiculo
    {
        public override void Mover()
        {
            Console.WriteLine($"{Tipo} navegando na agua");
        }
    }
}
