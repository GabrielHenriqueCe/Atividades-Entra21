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
    Pessoa pessoa = new Pessoa("Gabriel", 30);

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

void Atividade3()
{
    Conta conta = new Conta() { Saldo = 0 };
    bool sairAt3 = false;
    while (!sairAt3)
    {
        ContaExercicio3? opcaoAt3 = SelecionarOpcao<ContaExercicio3>();
        switch (opcaoAt3)
        {
            case ContaExercicio3.Depositar:
                Console.Clear();
                conta.Depositar();
                conta.ExibirSaldo();
                PausaParaLer();
                break;
            case ContaExercicio3.Sacar:
                Console.Clear();
                conta.Sacar();
                conta.ExibirSaldo();
                PausaParaLer();
                break;
            case ContaExercicio3.Sair:
                Console.WriteLine("\nVoltando ao menu principal...");
                sairAt3 = true;
                break;
            case null:
                Console.WriteLine("\nVoltando ao menu principal...");
                sairAt3 = true;
                break;
        }
    }
}

void Atividade4()
{
    Aluno aluno = new Aluno("Gabriel", 30, "Engenharia de Software", 0);

    bool notaValida = false;
    while (!notaValida)
    {
        try
        {
            aluno.SolicitarNota();
            notaValida = true;
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    aluno.ExibirInformacoes();
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
        case Exercicios.Exercicio3:
            Console.Clear();
            Atividade3();
            PausaParaLer();
            break;
        case Exercicios.Exercicio4:
            Console.Clear();
            Atividade4();
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