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

#endregion

#region Programa Principal

Exercicios? opcao = SelecionarOpcao<Exercicios>();

switch (opcao)
{
    case Exercicios.Exercicio1:
        Console.Clear();
        Atividade1();
        PausaParaLer();
        break;
    case Exercicios.Exercicio2:
        break;

    case Exercicios.ExercicioExtra:
        break;
    case null:
        Console.WriteLine("Obrigado pela visita");
        break;
}

#endregion