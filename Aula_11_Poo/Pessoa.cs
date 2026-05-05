using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_11_Poo
{
    internal class Pessoa
    {
        public string Nome { get; set; }
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

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos.");
            EhMaior();
            Console.WriteLine();
        }

        public static void Atividade2()
        {
            Pessoa[] pessoa = new Pessoa[1];
            pessoa[0] = new Pessoa();

            Console.Write("Digite o nome da pessoa: ");
            string nomeInput = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(nomeInput))
            {
                Console.WriteLine("O nome não pode ser vazio. Por favor, digite um nome válido.");
                Console.Write("Digite o nome da pessoa: ");
                nomeInput = Console.ReadLine();
            }
            pessoa[0].Nome = nomeInput;

            pessoa[0].FornecerIdade("Digite a idade da pessoa: ");



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
