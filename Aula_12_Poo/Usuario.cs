using Aula_12_Poo;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Utilities;
using static Utilities.Utils;

namespace Aula_12_Poo
{
    internal class Usuario : Pessoa
    {
        #region Propriedades
        private string _email { get; set; }

        public string Email
        {
            get { return _email; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("O e-mail do usuário não pode ser vazio. Por favor, insira um e-mail válido.");
                }
                else
                {
                    _email = value;
                }
            }
        }
        public Usuario(string nome, int idade, string email) : base(nome, idade)
        {
            Email = email;
        }

        #endregion

        #region Metodos

        public override void ExibirInformacoes()
        {
            Console.WriteLine($"Nome: {Nome}   Idade: {Idade} anos   Email: {Email}@C#.com.br");
        }

        #endregion
    }
}