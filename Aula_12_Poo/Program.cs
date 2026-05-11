using Aula_12_Poo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Utilities;
using static Utilities.Utils;
Console.OutputEncoding = Encoding.UTF8;

#region Atividades

void Atividade1()
{
    Produto produto = new Produto() { Nome = "Notebook" };
    produto.ExibirNome();
}

void Atividade2()
{
    Pessoa pessoa = new Pessoa() { Nome = "Gabriel", Idade = 30 };

    bool idadeValida = false;
    while (!idadeValida)
    {
        try
        {
            pessoa.SolicitarIdade();
            idadeValida = true;
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    pessoa.ExibirInformacoes();
}
#endregion

#region Programa Principal

bool sair = false;
while(!sair)
{
    Exercicios? opcao = SelecionarOpcao<Exercicios>();
    switch (opcao)
    {
        case Exercicios.Exercicio1:
            Console.Clear();
            Atividade1();
            PausaParaLer();
            break;
        case Exercicios.Exercicio2:
            Console.Clear();
            Atividade2();
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