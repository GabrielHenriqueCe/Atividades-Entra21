using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_13
{
    abstract class Personagem
    {
        public string Nome { get; set; }
        public int Vida { get; set; }
        public int Dano { get; set; }

        public abstract void Atacar(Personagem alvo);
    }
}
