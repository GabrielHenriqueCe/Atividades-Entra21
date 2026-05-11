using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_12_Poo
{
    internal class Produto
    {

        #region Propriedades
        private string _nome { get; set; }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("O nome do produto não pode ser vazio. Por favor, insira um nome válido.");
                }
                else
                {
                    _nome = value;
                }
            }
        }

        #endregion

        #region Métodos

        public void ExibirNome()
        {
            Console.WriteLine($"O nome do produto é: {Nome}");
        }

        #endregion
    }
}

