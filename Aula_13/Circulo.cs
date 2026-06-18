using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Aula_13
{
    internal class Circulo : Forma
    {
        public double Raio { get; set; }
        public override double CalcularArea() => Raio * Raio * Math.PI;


    }
}
