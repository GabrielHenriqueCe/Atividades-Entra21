using Aula_11_Poo;
using System.Security.Cryptography.X509Certificates;
class Program
{
    static void Main(string[] args)
    {
        bool sair = false;
        while (!sair)
        {
            Console.WriteLine("==== ATIVIDADES POO ====");
            Console.WriteLine("O menu segue a seguinte ordem:");
            Console.WriteLine("Opção - Numero da atividade - Classe - Objetivo.\n");
            Console.WriteLine("1 - Atividade 1 - Produto - Criar multiplos objetos");
            Console.WriteLine("2 - Atividade 2 - Pessoa - Interação com o usuário");
            Console.WriteLine("3 - Atividade 3 - Aluno - Lógica dentro da classe");
            Console.WriteLine("4 - Atividade 4 - Conta Bancaria - Evoluir comportamento");
            Console.WriteLine("5 - Atividade 5 - Produto - Uso de array com objetos");
            Console.WriteLine("6 - Atividade 6 - Pessoa - Busca simples");
            Console.WriteLine("7 - Atividade 7 - Produto - Comparação entre objetos");
            Console.WriteLine("8 - Atividade 8 - Aluno - Repetição + Cadastro");
            Console.WriteLine("9 - Atividade 9 - Conta Bancaria - Menu simples");
            Console.WriteLine("10 - Atividade 10 - Pessoa - Combinar Tudo");
            Console.WriteLine("11 - Atividade 11 - Aluno - Simulação Real");
            Console.WriteLine("12 - Sair\n");
            Console.Write("Escolha a Atividade:");
            string escolha = Console.ReadLine();
            Console.WriteLine();
            switch (escolha)
            {
                case "1":
                    Produto.Atividade1();
                    break;
                case "2":
                    Pessoa.Atividade2();
                    break;
                case "3":
                    Aluno.Atividade3();
                    break;
                case "4":
                    ContaBancaria.Atividade4();
                    break;
                case "5":
                    Produto.Atividade5();
                    break;
                case "6":
                    Pessoa.Atividade6();
                    break;
                case "7":
                    Produto.Atividade7();
                    break;
                case "8":
                    Aluno.Atividade8();
                    break;
                case "9":
                    ContaBancaria.Atividade9();
                    break;
                case "10":
                    Pessoa.Atividade10();
                    break;
                case "11":
                    Aluno.AtividadeDesafio();
                    break;
                case "12":
                    sair = true;
                    break;
                default:
                    Console.WriteLine("Escolha inválida. Por favor, digite um número entre 1 e 12.\n");
                    break;
            }
        }

    }
}