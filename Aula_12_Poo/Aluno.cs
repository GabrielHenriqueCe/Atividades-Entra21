using System;
using System.Collections.Generic;
using System.Text;
using Utilities;
using static Utilities.Utils;

namespace Aula_12_Poo
{
    internal class Aluno : Pessoa
    {
        #region Propriedades
        private string _curso { get; set; }
        private float _nota { get; set; }
        public string Curso
        {
            get { return _curso; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("O curso do aluno não pode ser vazio. Por favor, insira um curso válido.");
                }
                else
                {
                    _curso = value;
                }
            }
        }
        public float Nota
        {
            get { return _nota; }
            set
            {
                if (value < 0 || value > 10)
                {
                    throw new ArgumentException("A nota deve estar entre 0 e 10. Por favor, insira um valor válido.");
                }
                else
                {
                    _nota = value;
                }
            }
        }


        public Aluno(string nome, int idade, string curso, float nota) : base(nome, idade) 
        {
            Curso = curso;
            Nota = nota;
        }

        #endregion

        #region Metodos

        public void SolicitarNota()
        {
            Nota = LerFloat($"Digite a nota de {Nome}: ");
        }

        public override void ExibirInformacoes()
        {
            base.ExibirInformacoes();
            Console.WriteLine($"Curso: {Curso}    Nota: {Nota}");
        }

        #endregion
    }
}
