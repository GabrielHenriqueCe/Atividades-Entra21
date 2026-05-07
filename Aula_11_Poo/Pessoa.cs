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

        public void FornecerIdade(string mensagem)
        {
            Console.Write(mensagem);
            string idadeInput = Console.ReadLine();
            int idade = 0;
            while (!int.TryParse(idadeInput, out idade) || idade < 0)
            {
                if (idade < 0)
                {
                    Console.WriteLine("A idade não pode ser negativa. Por favor, digite um número válido para a idade.");
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, digite um número válido para a idade.");
                }
                Console.Write(mensagem);
                idadeInput = Console.ReadLine();
            }
            Idade = idade;
        }

        public void FornecerNome(string mensagem)
        {
            Console.Write(mensagem);
            string nomeInput = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(nomeInput))
            {
                Console.WriteLine("O nome não pode ser vazio. Por favor, digite um nome válido.");
                Console.Write(mensagem);
                nomeInput = Console.ReadLine();
            }
            Nome = nomeInput;
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"\nOlá, meu nome é {Nome} e tenho {Idade} anos.\n");
            EhMaior();
        }

        #endregion

    }
}