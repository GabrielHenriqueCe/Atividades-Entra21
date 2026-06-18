using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_13
{
    abstract class Empregado
    {
        public string Nome { get; set; }
        public double Salario { get; set; }
        public abstract double CalcularSalario();

        public Empregado (string nome, double salario)
        {
            Nome = nome;
            Salario = salario;
        }
    }
}
