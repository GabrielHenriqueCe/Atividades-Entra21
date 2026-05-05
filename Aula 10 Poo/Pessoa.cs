using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_10_Poo
{
    internal class Pessoa
    {
        public string Nome { get; set; }
        public string Curso { get; set; }
        public int Idade { get; set; }
        public bool ehMaior { get; set; }

        public bool EhMaior()
        {
            if (Idade >= 18)
            {
                Console.WriteLine($"O {Nome} é maior de idade.");
                ehMaior = true;
                return true;
            }
            else
            {
                Console.WriteLine($"O {Nome} é menor de idade.");
                ehMaior = false;
                return false;
            }
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos e estou cursando {Curso}.");
            EhMaior();
            Console.WriteLine();
        }

        public static void Atividade2()
        {
            Pessoa[] pessoa = new Pessoa[10];
            pessoa[0] = new Pessoa()
            {
                Nome = "Jose",
                Curso = "Medicina",
                Idade = 30
            };
            pessoa[1] = new Pessoa()
            {
                Nome = "Ana",
                Curso = "Veterinária",
                Idade = 18
            };

            for (int i = 0; i < pessoa.Length; i++)
            {
                if (pessoa[i] != null)
                {
                    pessoa[i].ExibirInformacoes();
                    Console.WriteLine();
                }
            }
        }
    }
}
