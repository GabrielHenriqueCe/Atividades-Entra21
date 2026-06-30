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

void Atividade5()
{
    Carro carro = new Carro() { Marca = "Renault", Modelo = "Kwid", VelocidadeAtual = 0 };

    bool velocidadeValida = false;
    int selecionado = 0;
    while (!velocidadeValida)
    {
        string[] opcoes = { $"1 - Acelerar", "2 - Frear", "3 - Sair", $"{carro.Velocimetro()}" };

        string? opcao = SelecionarComCursor(opcoes, out selecionado, selecionado);
        switch (opcao)
        {
            case "1 - Acelerar":
                Console.Clear();
                carro.Acelerar();
                break;
            case "2 - Frear":
                Console.Clear();
                carro.Frear();
                break;
            case "3 - Sair":
                Console.WriteLine("\nVoltando ao menu principal...");
                velocidadeValida = true;
                break;
            case null:
                velocidadeValida = true;
                break;
        }
    }
}

void AtividadeDesafio()
{
    GerenciadorUsuarios gerenciador = new GerenciadorUsuarios();

    bool sairAtDesafio = false;
    while (!sairAtDesafio)
    {
        ContaExercicioDesafio? opcaoDesafio = SelecionarOpcao<ContaExercicioDesafio>();
        switch (opcaoDesafio)
        {
            case ContaExercicioDesafio.Cadastrar:
                Console.Clear();
                gerenciador.Cadastrar();
                gerenciador.Listar();
                PausaParaLer();
                break;
            case ContaExercicioDesafio.Listar:
                Console.Clear();
                gerenciador.Listar();
                PausaParaLer();
                break;
            case ContaExercicioDesafio.Sair:
                Console.WriteLine("\nVoltando ao menu principal...");
                sairAtDesafio = true;
                break;
            case null:
                Console.WriteLine("\nVoltando ao menu principal...");
                sairAtDesafio = true;
                break;
        }
    }
}

void Teste()
{

    Carro carro = new Carro() { Marca = "Renault", Modelo = "Kwid", VelocidadeAtual = 0 };
    bool velocidadeValida = false;
    int selecionado = 0;
    while (!velocidadeValida)
    {
        Console.Clear();
        Console.WriteLine("W acelerar");
        Console.WriteLine("S para desacelerar");
        Console.WriteLine("X para Sair");
        Console.WriteLine(carro.Velocimetro());

        ConsoleKeyInfo tecla = Console.ReadKey(true);
        switch (tecla.Key)
        {
            case ConsoleKey.W:
                Console.Clear();
                carro.Acelerar();
                break;
            case ConsoleKey.S:
                Console.Clear();
                carro.Frear();
                break;
            case ConsoleKey.X:
                Console.WriteLine("\nVoltando ao menu principal...");
                velocidadeValida = true;
                break;
        }
    }
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
        case Exercicios.Exercicio5:
            Console.Clear();
            Atividade5();
            PausaParaLer();
            break;
        case Exercicios.ExercicioDesafio:
            Console.Clear();
            AtividadeDesafio();
            PausaParaLer();
            break;
        case Exercicios.Teste:
            Console.Clear();
            Teste();
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