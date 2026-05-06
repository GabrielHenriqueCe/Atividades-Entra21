using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_11_Poo
{
    internal class Aluno
    {
        public string Nome { get; set; }
        public string Curso { get; set; }
        public int Idade { get; set; }
        public float Nota { get; set; }
        public bool ehMaior { get; set; }

        public bool EhMaior()
        {
            if (Idade >= 18)
            {
                Console.WriteLine("O aluno é maior de idade.");
                ehMaior = true;
                return true;
            }
            else
            {
                Console.WriteLine("O aluno é menor de idade.");
                ehMaior = false;
                return false;
            }
        }

        public bool VerificarNota()
        {
            if (Nota >= 7)
            {
                Console.WriteLine($"O aluno foi aprovado com a nota {Nota}.");
                return true;
            }
            else
            {
                Console.WriteLine($"O aluno foi reprovado com a nota {Nota}.");
                return false;
            }
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos e estou cursando {Curso}.");
            EhMaior();
            VerificarNota();
            Console.WriteLine();
        }

        public static void Atividade3()
        {
            Aluno[] aluno = new Aluno[10];
            aluno[0] = new Aluno()
            {
                Nome = "João",
                Curso = "Engenharia de Software",
                Nota = 8.5f,
                Idade = 20
            };
            aluno[1] = new Aluno()
            {
                Nome = "Maria",
                Curso = "Ciência da Computação",
                Nota = 6.5f,
                Idade = 17
            };

            for (int i = 0; i < aluno.Length; i++)
            {
                if (aluno[i] != null)
                {
                    aluno[i].ExibirInformacoes();
                    Console.WriteLine();
                }
            }
        }
    }
}
