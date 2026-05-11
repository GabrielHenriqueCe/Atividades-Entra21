using System;
using System.Collections.Generic;
using System.Text;
using Utilities;
using static Utilities.Utils;

namespace Aula_12_Poo
{
    internal class Pessoa
    {
        #region Propriedades
        private string _nome { get; set; }
        private int _idade { get; set; }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("O nome da pessoa não pode ser vazio. Por favor, insira um nome válido.");
                }
                else
                { _nome = value; }
            }
        }

        public int Idade
        {
            get { return _idade; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A idade não pode ser negativa.");
                }
                else
                { _idade = value; }
            }
        }

        #endregion

        #region Métodos

        public void SolicitarIdade()
        {
            Console.Write($"Digite a Idade de {Nome}: ");
            int idade;
            while (!int.TryParse(Console.ReadLine(), out idade))
            {
                Console.Write("Entrada inválida. Digite um número inteiro: ");
            }
            Idade = idade;
        }
        public void ExibirInformacoes()
        {
            Console.WriteLine($"Nome: {Nome}    Idade: {Idade} anos");
        }

        #endregion
    }
}