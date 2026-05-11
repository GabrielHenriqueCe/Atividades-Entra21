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
        public Usuario() : base() { }

        #endregion

        #region Metodos
        public void Cadastrar()
        {
            Nome = LerStringObrigatoria("Digite o nome do usuário: ");
            Idade = LerInt($"Digite a Idade do usuário: ");
            Email = LerStringObrigatoria("Digite o email do usuário a assinatura será @C#.com.br: ");
        }

        public void Listar(List<Usuario> usuarios)
        {
            if (usuarios == null || usuarios.Count == 0)
            {
                Console.WriteLine("Nenhum usuário cadastrado.");
                return;
            }

            foreach (var usuario in usuarios)
            {
                Console.WriteLine($"Nome: {usuario.Nome},   Idade: {usuario.Idade},     Email: {usuario.Email}@C#.com.br ");
            }
        }

        public void InformarSituacao(Usuario usuarios)
        {
            base.ExibirInformacoes();
            Console.WriteLine($"Email: {usuarios.Email}@C#.com.br ");
        }

        #endregion
    }
}
