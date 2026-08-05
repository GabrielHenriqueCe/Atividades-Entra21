using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_11_Poo
{
    internal class Pessoa
    {
        #region Propriedades

        public string Nome { get; set; }
        public int Idade { get; set; }

        #endregion

        #region Metodos
        public bool EhMaior()
        {
            if (Idade >= 18)
            {
                Console.WriteLine($"O {Nome} é maior de idade.");
                return true;
            }
            else
            {
                Console.WriteLine($"O {Nome} é menor de idade.");
                return false;
            }
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"\nOlá, meu nome é {Nome} e tenho {Idade} anos.\n");
            EhMaior();
        }

        #endregion

    }
}