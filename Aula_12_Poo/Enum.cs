using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace Aula_12_Poo
{
    enum Exercicios
    {
        [Description("Exercício 1 - Classe Produto - Criar atributo privado")]
        Exercicio1 = 1,

        [Description("Exercício 2 - Classe Cliente - Validar valores")]
        Exercicio2,

        [Description("Exercício 3 - Classe Conta - Encapsular saldo")]
        Exercicio3,

        [Description("Exercício 4 - Classe Aluno - Utilizar property")]
        Exercicio4,

        [Description("Exercício 5 - Classe Carro - Acelerar e Frear")]
        Exercicio5,

        [Description("Exercício Extra - Desafio")]
        ExercicioDesafio,

        [Description("Sair - Esc")]
        Sair
    }

    enum ContaExercicio3
    {
        [Description("Depositar")]
        Depositar = 1,

        [Description("Sacar")]
        Sacar = 2,

        [Description("Sair - Esc")]
        Sair
    }

    enum ContaExercicioDesafio
    {
        [Description("Cadastrar Usuário")]
        Cadastrar = 1,

        [Description("Listar Usuários")]
        Listar = 2,

        [Description("Sair - Esc")]
        Sair
    }
}
