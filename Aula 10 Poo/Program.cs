using Aula_10_Poo;
using System.Security.Cryptography.X509Certificates;
class Program
{
    static void Main(string[] args)
    {
        bool sair = false;
        while (!sair)
        {
            Console.WriteLine("==== ATIVIDADES POO ====");
            Console.WriteLine("1 - Atividade 1 - Carro");
            Console.WriteLine("2 - Atividade 2 - Aluno + Extra");
            Console.WriteLine("3 - Atividade 3 - Produto");
            Console.WriteLine("4 - Atividade 4 - Conta Bancária");
            Console.WriteLine("5 - Sair\n");
            Console.Write("Escolha a Atividade:");
            string escolha = Console.ReadLine();
            Console.WriteLine();
            switch (escolha)
            {
                case "1":
                    Carro.Atividade1();
                    break;
                case "2":
                    Aluno.Atividade2();
                    break;
                case "3":
                    Produto.Atividade3();
                    break;
                case "4":
                    ContaBancaria.Atividade4();
                    break;
                case "5":
                    sair = true;
                    break;
                default:
                    Console.WriteLine("Escolha inválida. Por favor, digite um número entre 1 e 5.\n");
                    break;
            }
        }

    }
}