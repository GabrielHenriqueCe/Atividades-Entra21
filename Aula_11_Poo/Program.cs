using Aula_11_Poo;
class Program
{
    public static void PausaParaLer()
    {
        Console.WriteLine("\nPressione ENTER para continuar...");
        Console.ReadLine();
        Console.Clear();
    }
    static void Main(string[] args)
    {
        bool sair = false;
        while (!sair)
        {
            Console.Clear();
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
                    Console.Clear();
                    Produto.Atividade1();
                    PausaParaLer();
                    break;
                case "2":
                    Console.Clear();
                    Pessoa.Atividade2();
                    PausaParaLer();
                    break;
                case "3":
                    Console.Clear();
                    Aluno.Atividade3();
                    PausaParaLer();
                    break;
                case "4":
                    Console.Clear();
                    ContaBancaria.Atividade4();
                    PausaParaLer();
                    break;
                case "5":
                    Console.Clear();
                    Produto.Atividade5();
                    PausaParaLer();
                    break;
                case "6":
                    Console.Clear();
                    Pessoa.Atividade6();
                    PausaParaLer();
                    break;
                case "7":
                    Console.Clear();
                    Produto.Atividade7();
                    PausaParaLer();
                    break;
                case "8":
                    Console.Clear();
                    Aluno.Atividade8();
                    PausaParaLer();
                    break;
                case "9":
                    Console.Clear();
                    ContaBancaria.Atividade9();
                    PausaParaLer();
                    break;
                case "10":
                    Console.Clear();
                    Pessoa.Atividade10();
                    PausaParaLer();
                    break;
                case "11":
                    Console.Clear();
                    Aluno.AtividadeDesafio();
                    PausaParaLer();
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