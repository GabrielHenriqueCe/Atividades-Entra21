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
            Console.WriteLine("1 - Atividade 1 - Produto");
            Console.WriteLine("2 - Atividade 2 - Pessoa");
            Console.WriteLine("3 - Atividade 3 - Aluno");
            Console.WriteLine("4 - Atividade 4 - Conta Bancaria");
            Console.WriteLine("5 - Atividade 5 - Produto");
            Console.WriteLine("6 - Atividade 6 - Pessoa");
            //Aguardando proximos exercicios
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
                case "12":
                    sair = true;
                    break;
                default:
                    Console.WriteLine("Escolha inválida. Por favor, digite um número entre 1 e 6.\n");
                    break;
            }
        }

    }
}