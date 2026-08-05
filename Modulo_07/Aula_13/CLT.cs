using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_13
{
    internal class CLT : Empregado
    {
        public override double CalcularSalario() => Salario;

        public CLT(string nome, double salario) : base(nome, salario) { }
    }
}
