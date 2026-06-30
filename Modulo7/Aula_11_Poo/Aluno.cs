using Aula_11_Poo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_11_Poo
{
    internal class Aluno
    {
        #region Propriedades

        public string Nome { get; set; }
        public string Curso { get; set; }
        public byte Idade { get; set; }
        public float Nota { get; set; }
        public bool ehMaior { get; set; }

        #endregion

        #region Metodos

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
                return true;
            }
            else
            {

                return false;
            }
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos e estou cursando {Curso}.");
            EhMaior();
            if (VerificarNota())
            {
                Console.WriteLine($"O aluno foi aprovado com nota {Nota}.");
            }
            else
            {
                Console.WriteLine($"O aluno foi reprovado com nota {Nota}.");
            }
            Console.WriteLine();
        }

        #endregion

    }
}
