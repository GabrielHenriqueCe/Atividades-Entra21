using System;
using System.Collections.Generic;
using System.Text;
using Utilities;
using static Utilities.Utils;

namespace Aula_12_Poo
{
    internal class Pessoa
    {
        private string _nome { get; set; }
        private byte _idade { get; set; }

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
                {
                    _nome = value;
                }
            }
        }

        public byte Idade
        {
            get { return _idade; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("A idade da pessoa não pode ser negativa. Por favor, insira uma idade válida.");
                }
                else
                { _idade = value; }
            }
        }

        public void SolicitarIdade()
        {
            Idade = LerByte(
                $"Digite a idade de {Nome}: ",
                "Entrada inválida. Digite um número válido: ",
                0,
                120
            );
        }
    }
}