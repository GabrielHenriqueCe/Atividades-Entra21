using Aula_11_Poo;
using System.Drawing;
using Utilities;
using static Utilities.Utils;

#region Metodos ContaBancaria

void CadastrarConta(ContaBancaria[] contas, ref int contador)
{
    Console.WriteLine("==== CADASTRO DE CONTA BANCARIA ==== ");
    if (contador >= contas.Length)
    {
        Console.WriteLine("Limite de contas atingido. Não é possível cadastrar mais contas.");
        return;
    }

    contas[contador] = new ContaBancaria();
    contas[contador].Titular = LerStringObrigatoria("Digite o nome do titular da conta: ", "O nome do titular é obrigatório. Digite novamente: ");
    contas[contador].Valor = 0;
    contador++;
}

#endregion

#region Metodos Alunos

void CadastrarAluno(Aluno[] alunos, ref int contador)
{

    var titulo = " CADASTRO DE ALUNOS  ";
    if (contador == alunos.Length)
    {
        AlertaLimiteCadastro("Limite de alunos cadastrados atingido");
        return;
    }
    Console.WriteLine("==== CADASTRO DE ALUNOS ==== ");

    alunos[contador] = new Aluno();
    alunos[contador].Nome = LerStringObrigatoria("Digite o nome do aluno: ", "O nome do aluno é obrigatório. Digite novamente: ");
    alunos[contador].Idade = LerByte("Digite a idade do aluno: ", "Idade inválida. Digite uma idade numérica positiva: ", 0, byte.MaxValue);
    alunos[contador].Nota = LerFloat("Digite a nota do aluno: ", "Nota inválida. Digite uma nota entre 0 e 10: ", 0, 10);
    contador++;
}

void ListarAlunos(Aluno[] alunos)
{
    Console.WriteLine("\n==== LISTA DE ALUNOS ====");
    if (alunos[0] == null)
    {
        Console.WriteLine("Nenhum aluno cadastrado.");
        return;
    }
    for (int i = 0; i < alunos.Length; i++)
    {
        if (alunos[i] != null)
        {
            Console.WriteLine($"Aluno {i + 1}:  Nome: {alunos[i].Nome}   Idade: {alunos[i].Idade}   Nota: {alunos[i].Nota}");
        }
        else
        {
            break;
        }
    }
}

void ExibirMediaTurma(Aluno[] alunos)
{
    float somaNotas = 0;
    int quantidadeAlunos = 0;
    for (int i = 0; i < alunos.Length; i++)
    {
        if (alunos[i] != null)
        {
            somaNotas += alunos[i].Nota;
            quantidadeAlunos++;
        }
        else
        {
            break;
        }
    }
    if (quantidadeAlunos > 0)
    {
        float media = somaNotas / quantidadeAlunos;
        Console.WriteLine($"A média da turma é: {media:F2}");
    }
    else
    {
        Console.WriteLine("Nenhum aluno cadastrado para calcular a média.");
    }
}

void QuantidadeAprovados(Aluno[] alunos)
{
    int quantidadeAprovados = 0;
    for (int i = 0; i < alunos.Length; i++)
    {
        if (alunos[i] != null)
        {
            if (alunos[i].VerificarNota())
            {
                quantidadeAprovados++;
            }
        }
        else
        {
            break;
        }
    }
    Console.WriteLine($"Quantidade de alunos aprovados: {quantidadeAprovados}");
}

void ListarAprovados(Aluno[] alunos)
{
    Console.WriteLine("\n==== ALUNOS APROVADOS ====");
    bool temAprovados = false;
    for (int i = 0; i < alunos.Length; i++)
    {
        if (alunos[i] != null)
        {
            if (alunos[i].VerificarNota())
            {
                Console.WriteLine($"Aluno {i + 1}:  Nome: {alunos[i].Nome}   Idade: {alunos[i].Idade}   Nota: {alunos[i].Nota}");
                temAprovados = true;
            }
        }
        else
        {
            break;
        }
    }
    if (!temAprovados)
    {
        Console.WriteLine("Nenhum aluno aprovado.");
    }
}

#endregion

#region Metodos Pessoa

void BuscarNome(Pessoa[] pessoa)
{
    string nomeInput = LerStringObrigatoria("Digite o nome que deseja buscar: ", "O nome é obrigatório. Digite novamente: ");
    bool encontrado = pessoa.Any(p => p != null && p.Nome.ToLower() == nomeInput.ToLower());
    if (encontrado)
    {
        Console.WriteLine($"\nO nome {nomeInput} foi encontrado.\n");
    }
    else
    {
        Console.WriteLine($"\nO nome {nomeInput} não foi encontrado.\n");
    }
}

void ListarNomes(Pessoa[] pessoas)
{
    if (pessoas[0] == null)
    {
        Console.WriteLine("\nNenhuma pessoa cadastrada\n");
        return;
    }
    Console.WriteLine("\n==== LISTA DE PESSOAS ====");
    foreach (var pessoa in pessoas)
    {
        if (pessoa != null)
        {
            Console.WriteLine($"Nome: {pessoa.Nome}, Idade: {pessoa.Idade}");
        }
        else
        {
            break;
        }
    }
    Console.WriteLine();
}

void CadastrarPessoa(Pessoa[] pessoa, ref int contador)
{
    if (contador == pessoa.Length)
    {
        AlertaLimiteCadastro("Limite de pessoas cadastradas atingido");
        return;
    }

    Console.WriteLine("\n==== CADASTRO DE PESSOA ==== ");

    Pessoa novaPessoa = new Pessoa();
    pessoa[contador].Nome = LerStringObrigatoria("Digite o nome da pessoa: ", "O nome da pessoa é obrigatório. Digite novamente: ");
    pessoa[contador].Idade = LerByte("Digite a idade da pessoa: ", "Idade inválida. Digite uma idade numérica positiva: ", 0, byte.MaxValue);
    contador++;
}

#endregion

#region Metodos Produto

void ListarProdutos(Produto[] produtos)
{
    Console.WriteLine("\n==== LISTA DE PRODUTOS ====");
    if (produtos[0] == null)
    {
        Console.WriteLine("Nenhum produto cadastrado.");
        return;
    }
    foreach (Produto produto in produtos)
    {
        if (produto != null)
        {
            Console.WriteLine($"Produto: {produto.Nome}, Valor: {produto.Valor}");
        }
        else
        {
            break;
        }
    }
    Console.WriteLine();
}

void ProdutoMaisCaro(Produto[] produtos)
{
    Produto produtoMaisCaro = produtos[0];
    for (int i = 1; i < produtos.Length; i++)
    {
        if (produtos[i].Valor > produtoMaisCaro.Valor)
        {
            produtoMaisCaro = produtos[i];
        }
    }
    Console.WriteLine($"\nO produto mais caro é: {produtoMaisCaro.Nome} com o valor de {produtoMaisCaro.Valor}.");
}

void CadastrarProduto(Produto[] produtos, ref int contador)
{
    if (contador == produtos.Length)
    {
        AlertaLimiteCadastro("Limite de produtos cadastrados atingido");
        return;
    }
    Console.WriteLine("==== CADASTRO DE PRODUTOS ==== ");

    produtos[contador] = new Produto();
    produtos[contador].Nome = LerStringObrigatoria("Digite o nome do produto: ", "O nome do produto é obrigatório. Digite novamente: ");
    produtos[contador].Valor = LerDecimal("Digite o valor do produto: ", "Valor inválido. Digite um valor numérico positivo: ", 0, decimal.MaxValue);
    contador++;
}

#endregion

#region Atividades

void Atividade1()
{
    Produto[] produtos =
    {
                new Produto() { Nome = "Notebook", Valor = 3000 },
                new Produto() { Nome = "Smartphone", Valor = 8000 },
                new Produto() { Nome = "Tablet", Valor = 1500 }
            };


    for (int i = 0; i < produtos.Length; i++)
    {
        produtos[i].ExibirInformacoes();
    }
}

void Atividade2()
{
    Pessoa[] pessoa = { new Pessoa() };

    pessoa[0].Nome = LerStringObrigatoria("Digite o nome da pessoa: ", "O nome é obrigatório. Digite novamente: ");

    pessoa[0].Idade = LerByte("Digite a idade da pessoa: ", "Idade inválida. Digite uma idade numérica positiva: ", 0, byte.MaxValue);


    for (int i = 0; i < pessoa.Length; i++)
    {
        if (pessoa[i] != null)
        {
            pessoa[i].ExibirInformacoes();
            Console.WriteLine();
        }
    }
}
void Atividade3()
{
    Aluno[] aluno = new Aluno[10];
    aluno[0] = new Aluno()
    {
        Nome = "João",
        Curso = "Engenharia de Software",
        Nota = 8.5f,
        Idade = 20
    };
    aluno[1] = new Aluno()
    {
        Nome = "Maria",
        Curso = "Ciência da Computação",
        Nota = 6.5f,
        Idade = 17
    };

    for (int i = 0; i < aluno.Length; i++)
    {
        if (aluno[i] != null)
        {
            aluno[i].ExibirInformacoes();
            Console.WriteLine();
        }
    }
}

void Atividade4()
{
    ContaBancaria[] contas = new ContaBancaria[2];
    contas[0] = new ContaBancaria()
    {
        Titular = "João",
        Valor = 30000
    };

    bool sair = false;
    while (!sair)
    {
        Console.WriteLine("==== DIGITE UMA OPCAO ====");
        Console.WriteLine("1 - Depositar");
        Console.WriteLine("2 - Sacar");
        Console.WriteLine("3 - Sair");
        string opcao = Console.ReadLine();
        switch (opcao)
        {
            case "1":
                Console.Clear();
                contas[0].Depositar($"Digite o valor a ser depositado na conta de {contas[0].Titular}:");
                contas[0].ExibirInformacoes();
                PausaParaLer();
                break;
            case "2":
                Console.WriteLine();
                contas[0].Sacar($"Digite o valor a ser sacado da conta de {contas[0].Titular}:");
                contas[0].ExibirInformacoes();
                PausaParaLer();
                break;
            case "3":
                sair = true;
                break;
        }
    }
}

void Atividade5()
{
    Produto[] produtos = new Produto[3];
    int contador = 0;
    bool sair = false;
    while (!sair)
    {
        Console.WriteLine("\n==== MENU DE PRODUTOS ====");
        Console.WriteLine("1 - Cadastrar produto");
        Console.WriteLine("2 - Listar produtos");
        Console.WriteLine("3 - Sair");
        Console.Write("Escolha uma opção: ");
        string entrada = Console.ReadLine();
        switch (entrada)
        {
            case "1":
                Console.Clear();
                CadastrarProduto(produtos, ref contador);
                PausaParaLer();
                break;
            case "2":
                Console.Clear();
                ListarProdutos(produtos);
                PausaParaLer();
                break;
            case "3":
                sair = true;
                break;
            default:
                Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
                break;
        }
    }
}

void Atividade6()
{
    Pessoa[] pessoa =
    {
        new Pessoa() { Nome = "Eduardo", Idade = 25 },
        new Pessoa() { Nome = "Ana", Idade = 17 },
        new Pessoa() { Nome = "Gabriel", Idade = 30 },
        new Pessoa() { Nome = "Jose", Idade = 15 },
        new Pessoa() { Nome = "Henrique", Idade = 22 }
    };

    bool sair;
    do
    {
        Console.WriteLine("==== MENU ====");
        Console.WriteLine("1. Listar Nomes");
        Console.WriteLine("2. Buscar Nome");
        Console.WriteLine("3. Sair");
        Console.Write("Escolha uma opção: ");
        string opcao = Console.ReadLine();
        switch (opcao)
        {
            case "1":
                Console.Clear();
                ListarNomes(pessoa);
                sair = false;
                PausaParaLer();
                break;
            case "2":
                Console.Clear();
                BuscarNome(pessoa);
                sair = false;
                PausaParaLer();
                break;
            case "3":
                sair = true;
                break;
            default:
                Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
                sair = false;
                break;
        }
    } while (!sair);
}

void Atividade7()
{
    Produto[] produtos =
{
                new Produto() { Nome = "Notebook", Valor = 3000 },
                new Produto() { Nome = "Smartphone", Valor = 8000 },
                new Produto() { Nome = "Tablet", Valor = 1500 }
            };

    bool sair;
    do
    {
        Console.WriteLine("\n==== MENU DE PRODUTOS ====");
        Console.WriteLine("1 - Listar produtos");
        Console.WriteLine("2 - Exibir produto mais caro");
        Console.WriteLine("3 - Sair");
        Console.Write("Escolha uma opção: ");
        string entrada = Console.ReadLine();
        switch (entrada)
        {
            case "1":
                Console.Clear();
                ListarProdutos(produtos);
                sair = false;
                PausaParaLer();
                break;
            case "2":
                Console.Clear();
                ProdutoMaisCaro(produtos);
                sair = false;
                PausaParaLer();
                break;
            case "3":
                sair = true;
                break;
            default:
                Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
                sair = false;
                break;
        }
    } while (!sair);
}

void Atividade8()
{
    Aluno[] alunos = new Aluno[3];
    int contador = 0;
    bool sair = false;
    while (!sair)
    {
        Console.WriteLine("==== MENU DE ALUNOS ====");
        Console.WriteLine("1 - Cadastrar aluno");
        Console.WriteLine("2 - Listar alunos");
        Console.WriteLine("3 - Sair");
        Console.Write("Escolha uma opção: ");
        string entrada = Console.ReadLine();
        switch (entrada)
        {
            case "1":
                Console.Clear();
                CadastrarAluno(alunos, ref contador);
                PausaParaLer();
                break;
            case "2":
                Console.Clear();
                ListarAlunos(alunos);
                PausaParaLer();
                break;
            case "3":
                sair = true;
                break;
            default:
                Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
                break;
        }
    }
}

void Atividade9()
{
    ContaBancaria[] contas = new ContaBancaria[1];
    int contador = 0;
    int indiceConta = 0;
    bool sair = false;
    while (!sair)
    {
        Console.WriteLine("==== DIGITE UMA OPCAO ====");
        Console.WriteLine("1 - Criar Conta");
        Console.WriteLine("2 - Depositar");
        Console.WriteLine("3 - Sacar");
        Console.WriteLine("4 - Exibir Saldo");
        Console.WriteLine("5 - Sair");
        string opcao = Console.ReadLine();
        switch (opcao)
        {
            case "1":
                Console.Clear();
                CadastrarConta(contas, ref contador);
                PausaParaLer();
                break;
            case "2":
                Console.Clear();
                contas[indiceConta].Depositar($"Digite o valor a ser depositado na conta de {contas[indiceConta].Titular}:");
                contas[indiceConta].ExibirInformacoes();
                PausaParaLer();
                break;
            case "3":
                Console.Clear();
                contas[indiceConta].Sacar($"Digite o valor a ser sacado da conta de {contas[indiceConta].Titular}:");
                contas[indiceConta].ExibirInformacoes();
                PausaParaLer();
                break;
            case "4":
                Console.Clear();
                contas[indiceConta].ExibirInformacoes();
                PausaParaLer();
                break;
            case "5":
                sair = true;
                break;
        }
    }
}

void Atividade10()
{
    Pessoa[] pessoa = new Pessoa[5];
    int contador = 0;
    bool sair;
    do
    {
        Console.WriteLine("==== MENU ====");
        Console.WriteLine("1. Cadastrar Pessoa");
        Console.WriteLine("2. Listar Nomes");
        Console.WriteLine("3. Buscar Nome");
        Console.WriteLine("4. Sair");
        Console.Write("Escolha uma opção: ");
        string opcao = Console.ReadLine();
        switch (opcao)
        {
            case "1":
                Console.Clear();
                CadastrarPessoa(pessoa, ref contador);
                sair = false;
                PausaParaLer();
                break;
            case "2":
                Console.Clear();
                ListarNomes(pessoa);
                sair = false;
                PausaParaLer();
                break;
            case "3":
                Console.Clear();
                BuscarNome(pessoa);
                sair = false;
                PausaParaLer();
                break;
            case "4":
                sair = true;
                break;
            default:
                Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
                sair = false;
                break;
        }
    } while (!sair);
}

void AtividadeDesafio()
{
    Aluno[] alunos = new Aluno[3];
    int contador = 0;
    bool sair = false;
    while (!sair)
    {
        Console.WriteLine("==== MENU DE ALUNOS ====");
        Console.WriteLine("1 - Cadastrar aluno");
        Console.WriteLine("2 - Listar alunos");
        Console.WriteLine("3 - Mostrar média");
        Console.WriteLine("4 - Quantidade de aprovados");
        Console.WriteLine("5 - Listar aprovados");
        Console.WriteLine("6 - Sair");
        Console.Write("Escolha uma opção: ");
        string entrada = Console.ReadLine();
        switch (entrada)
        {
            case "1":
                Console.Clear();
                CadastrarAluno(alunos, ref contador);
                PausaParaLer();
                break;
            case "2":
                Console.Clear();
                ListarAlunos(alunos);
                PausaParaLer();
                break;
            case "3":
                Console.Clear();
                ExibirMediaTurma(alunos);
                PausaParaLer();
                break;
            case "4":
                Console.Clear();
                QuantidadeAprovados(alunos);
                PausaParaLer(); break;
            case "5":
                Console.Clear();
                ListarAprovados(alunos);
                PausaParaLer(); break;
            case "6":
                sair = true;
                break;
            default:
                Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
                break;
        }
    }
}

#endregion

#region Programa Principal

bool sair = false;
while (!sair)
{
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
            Atividade1();
            PausaParaLer(); break;
        case "2":
            Console.Clear();
            Atividade2();
            PausaParaLer(); break;
        case "3":
            Console.Clear();
            Atividade3();
            PausaParaLer(); break;
        case "4":
            Console.Clear();
            Atividade4();
            PausaParaLer(); break;
        case "5":
            Console.Clear();
            Atividade5();
            PausaParaLer(); break;
        case "6":
            Console.Clear();
            Atividade6();
            PausaParaLer(); break;
        case "7":
            Console.Clear();
            Atividade7();
            PausaParaLer(); break;
        case "8":
            Console.Clear();
            Atividade8();
            PausaParaLer(); break;
        case "9":
            Console.Clear();
            Atividade9();
            PausaParaLer(); break;
        case "10":
            Console.Clear();
            Atividade10();
            PausaParaLer(); break;
        case "11":
            Console.Clear();
            AtividadeDesafio();
            PausaParaLer(); break;
        case "12":
            sair = true;
            break;
        default:
            Console.WriteLine("Escolha inválida. Por favor, digite um número entre 1 e 12.\n");
            break;
    }
}

#endregion