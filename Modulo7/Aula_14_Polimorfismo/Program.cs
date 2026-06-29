using Aula_14_Polimorfismo;
using System.Text;
using Utilities;
using static Utilities.Utils;
Console.OutputEncoding = Encoding.UTF8;

#region Program
bool sair = false;
while (!sair)
{
    Exercicios? opcao = SelecionarOpcao<Exercicios>();
    switch (opcao)
    {
        case Exercicios.Exercicio1:
            Console.Clear();
            Atividades.Atividade1();
            PausaParaLer();
            break;
        case Exercicios.Exercicio2:
            Console.Clear();
            Atividades.Atividade2();
            PausaParaLer();
            break;
        case Exercicios.Sair:
            Console.WriteLine("\nObrigado pela visita");
            sair = true;
            break;
        case null:
            Console.WriteLine("\nObrigado pela visita");
            sair = true;
            break;
    }
}
#endregion