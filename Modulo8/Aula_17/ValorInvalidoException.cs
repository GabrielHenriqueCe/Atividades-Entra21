using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_17
{
    internal class ValorInvalidoException : Exception
    {
        public ValorInvalidoException(decimal valor) 
            : base ($"\nO valor não pode ser R${valor:F2}\n") { }
    }
}
