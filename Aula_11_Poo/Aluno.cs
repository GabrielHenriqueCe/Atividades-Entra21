using Aula_11_Poo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_11_Poo
{
    internal class Aluno
    {
        public string Nome { get; set; }
        public string Curso { get; set; }
        public byte Idade { get; set; }
        public float Nota { get; set; }
        public bool ehMaior { get; set; }

        public bool EhMaior()
        {
            if (Idade >= 18)
            {
                Console.WriteLine("O aluno é maior de idade.");
                ehMaior = true;
                return true;
            }
            else
            {
                Console.WriteLine("O aluno é menor de idade.");
                ehMaior = false;
                return false;
            }
        }

        public bool VerificarNota()
        {
            if (Nota >= 7)
            {
                Console.WriteLine($"O aluno foi aprovado com a nota {Nota}.");
                return true;
            }
            else
            {
                Console.WriteLine($"O aluno foi reprovado com a nota {Nota}.");
                return false;
            }
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos e estou cursando {Curso}.");
            EhMaior();
            VerificarNota();
            Console.WriteLine();
        }

        public static void Atividade3()
        {
            Aluno[] aluno = new Aluno[10];
            aluno[0] = new Aluno()
            {
                Nome = "João",
                Curso = "Engenharia de Software",
                Nota = 8.5f,
                Idade = 20
            };
            aluno[1] = new Aluno()
            {
                Nome = "Maria",
                Curso = "Ciência da Computação",
                Nota = 6.5f,
                Idade = 17
            };

            for (int i = 0; i < aluno.Length; i++)
            {
                if (aluno[i] != null)
                {
                    aluno[i].ExibirInformacoes();
                    Console.WriteLine();
                }
            }
        }

        public static void CadastrarAluno(Aluno[] alunos, ref int contador)
        {

            if (contador == alunos.Length)
            {
                Console.OutputEncoding = System.Text.Encoding.UTF8;
                Console.WriteLine("\n⚠️ ALERTA ⚠️");
                Console.WriteLine("Limite de alunos cadastrados atingidos\n");
            }
            Console.WriteLine("==== CADASTRO DE ALUNOS ==== ");
            for (int i = 0; i < alunos.Length; i++)
            {
                Console.Write("Digite o nome do aluno: ");
                alunos[contador] = new Aluno();
                alunos[contador].Nome = Console.ReadLine();
                while (string.IsNullOrEmpty(alunos[contador].Nome))
                {
                    Console.Write("O nome do aluno é obrigatório. Digite novamente: ");
                    alunos[contador].Nome = Console.ReadLine();
                }
                Console.Write("Digite a idade do aluno: ");
                string idadeInput = Console.ReadLine();
                byte idade;
                while (!byte.TryParse(idadeInput, out idade) || idade <= 0)
                {
                    Console.Write("Idade inválida. Digite uma idade numérica positiva: ");
                    idadeInput = Console.ReadLine();
                }
                alunos[contador].Idade = idade;
                Console.Write("Digite a nota do aluno: ");
                string notaInput = Console.ReadLine();
                float nota;
                while (!float.TryParse(notaInput, out nota) || nota < 0 || nota > 10)
                {
                    Console.Write("Nota inválida. Digite uma nota entre 0 e 10: ");
                    notaInput = Console.ReadLine();
                }
                alunos[contador].Nota = nota;
                contador++;
                break;
            }
        }

        public static void ListarAlunos(Aluno[] alunos)
        {
            Console.WriteLine("\n==== LISTA DE ALUNOS ====");
            if(alunos[0] == null)
            {
                Console.WriteLine("Nenhum aluno cadastrado.");
                return;
            }
            for (int i = 0; i < alunos.Length; i++)
            {
                if (alunos[i] != null)
                {
                    Console.WriteLine($"Aluno {i +1}:");
                    Console.WriteLine($"Nome: {alunos[i].Nome}");
                    Console.WriteLine($"Idade: {alunos[i].Idade}");
                    Console.WriteLine($"Nota: {alunos[i].Nota}");
                    Console.WriteLine();
                }
                else
                {
                    break;
                }
            }
        }

        public static void Atividade8()
        {
            Aluno[] alunos = new Aluno[3];
            int contador = 0;
            bool sair = false;
            while (!sair)
            {
                Console.WriteLine("\n==== MENU DE ALUNOS ====");
                Console.WriteLine("1 - Cadastrar aluno");
                Console.WriteLine("2 - Listar alunos");
                Console.WriteLine("3 - Sair");
                Console.Write("Escolha uma opção: ");
                string entrada = Console.ReadLine();
                switch (entrada)
                {
                    case "1":
                        CadastrarAluno(alunos, ref contador);
                        break;
                    case "2":
                        ListarAlunos(alunos);
                        break;
                    case "3":
                        sair = true;
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
                        break;
                }
            }
        }
    }
}
