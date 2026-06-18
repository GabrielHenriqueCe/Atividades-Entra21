using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;

namespace Aula_13
{
    internal class PJ : Empregado
    {
        public double ValorHoras { get; set; }
        public double Horas {  get; set; }
        public override double CalcularSalario() => Salario = ValorHoras * Horas;

        public PJ(double valorHoras, double horas, string nome, double salario) :base (nome, salario) 
        {
            ValorHoras = valorHoras;
            Horas = horas;
        }
    }
}
