using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_14_Polimorfismo
{
    abstract class Pagamento
    {
        public double Valor {  get; set; }
        public abstract void Processar();
    }
}
