using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_13
{
    internal class Guerreiro : Personagem
    {
        public override void Atacar(Personagem alvo)
        {
            Dano = 30;
            alvo.Vida -= Dano;
            Console.WriteLine($"Guerreiro Ataca com Espada e causa {Dano} no {alvo.Nome}");
            Console.WriteLine($"\n{alvo.Nome} ficou com {alvo.Vida} de vida");
        }
    }
}
