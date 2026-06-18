using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_13
{
    internal class Arqueiro : Personagem
    {
        public int Flecha {  get; set; }
        public override void Atacar(Personagem alvo)
        {
            if (Flecha <= 0)
            { Console.WriteLine("Arqueiro ficou sem flecha"); return; }
            Dano = 20;
            Flecha--;
            alvo.Vida -= Dano;
            Console.WriteLine($"Arqueiro atira flecha e causa {Dano} no {alvo.Nome}");
            Console.WriteLine($"Tem {Flecha} flecha");
            Console.WriteLine($"\n{alvo.Nome} ficou com {alvo.Vida} de vida");
        }
    }
}
