using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_13
{
    abstract class Conta
    {
        public double Saldo { get; set; }

        public abstract void TipoDescricao();
    }
}
