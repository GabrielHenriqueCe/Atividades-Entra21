using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_13
{
    internal class Mago : Personagem
    {
        public int Mana { get; set; }
        public override void Atacar(Personagem alvo)
        {
            if (Mana <= 0)
            { Console.WriteLine("Mago ficou sem mana"); return; }
            Mana -= 10;
            Dano = 50;
            alvo.Vida -= Dano;
            Console.WriteLine($"Mago Ataca com Magia e causa {Dano} no {alvo.Nome}");
            Console.WriteLine($"Consumiu {Mana} de mana");

            Console.WriteLine($"\n{alvo.Nome} ficou com {alvo.Vida} de vida");
        }
    }
}
