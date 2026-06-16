using Aula_17;

void PausaParaLer()
{
    Console.Write("\nDigite ENTER para continuar...");
    Console.ReadLine();
}
bool sair = false;
while (!sair)
{
    Console.Clear();
    Console.WriteLine("1 - Atividade 1");
    Console.WriteLine("2 - Atividade 2");
    Console.WriteLine("3 - Atividade 3");
    Console.WriteLine("4 - Atividade 4");
    Console.WriteLine("5 - Atividade 5");
    Console.WriteLine("6 - Atividade Extra");
    Console.WriteLine("x - sair");
    Console.Write("Escolha uma opção do Menu: ");
    string entrada = Console.ReadLine();
    switch (entrada)
    {
        case "1":
            Console.Clear();
            Atividades.At1();
            PausaParaLer();
            break;
        case "2":
            Console.Clear();
            Atividades.At2();
            PausaParaLer();
            break;
        case "3":
            Console.Clear();
            Atividades.At3();
            PausaParaLer();
            break;
        case "4":
            Console.Clear();
            Atividades.At4();
            PausaParaLer();
            break;
        case "5":
            Console.Clear();
            Atividades.At5();
            PausaParaLer();
            break;
        case "6":
            Console.Clear();
            Atividades.AtExtra();
            PausaParaLer();
            break;
        case "x":
            sair = true;
            break;
        default:
            Console.WriteLine("Digite uma opção válida!");
            break;
    }
}