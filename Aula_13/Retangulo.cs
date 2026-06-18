using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_13
{
    internal class Retangulo : Forma
    {
        public double Largura { get; set; }
        public double Altura { get; set; }

        public override double CalcularArea() => Largura * Altura;
    }
}
