using System;
using System.Collections.Generic;
using System.Text;
using Utilities;
using static Utilities.Utils;

namespace Aula_12_Poo
{
    public class GerenciadorUsuarios
    {
        private List<Usuario> _usuarios = new List<Usuario>()
        {
            new Usuario("Gabriel", 30, "gabriel")
        };

        public void Cadastrar()
        {
            string nome = LerStringObrigatoria("Digite o nome: ");
            int idade = LerInt("Digite a idade: ");
            string email = LerStringObrigatoria("Digite o email: ");

            _usuarios.Add(new Usuario(nome, idade, email));
        }

        public void Listar()
        {
            if (_usuarios.Count == 0)
            {
                Console.WriteLine("Nenhum usuário cadastrado.");
                return;
            }

            foreach (var u in _usuarios)
                u.ExibirInformacoes();
        }
    }
}
