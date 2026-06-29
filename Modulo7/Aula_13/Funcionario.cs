using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_13
{
    internal class Funcionario : Pessoa
    {
        public string Cargo { get; set; }

        public Funcionario(string cargo, string nome, int idade) : base(nome, idade)
        {
            Cargo = cargo;
        }
    }
}
