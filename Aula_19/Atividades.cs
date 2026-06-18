using Aula_19.Excecoes;
using Aula_19.Modelos;
using Aula_19.Repositorios;
using Aula_19.Servicos;
using ConsoleTables;
using Newtonsoft.Json;

namespace Aula_19
{
    internal class Atividades
    {
        public static void At1()
        {
            List<Produto> produtos = new List<Produto>()
            {
                new Produto(1, "Mouse", "Periféricos", 89.90m),
                new Produto(2, "Cadeira Gamer", "Móveis", 1299.90m),
                new Produto(3, "Headset", "Áudio", 199.90m),
                new Produto(4, "SSD 480GB", "Armazenamento", 249.90m),
                new Produto(5, "Webcam", "Câmeras", 159.90m)
            };

            foreach (var p in produtos)
            {
                Console.WriteLine($"ID: {p.Id} | Nome: {p.Nome} | Categoria: {p.Categoria} | Preço: R$ {p.Preco:F2}");
            }
        }

        public static void At2()
        {
            RepositorioProduto repositorio = new RepositorioProduto();

            repositorio.Adicionar(new Produto(1, "Mouse", "Periféricos", 89.90m));
            repositorio.Adicionar(new Produto(2, "Cadeira Gamer", "Móveis", 1299.90m));
            repositorio.Adicionar(new Produto(3, "Headset", "Áudio", 199.90m));
            repositorio.Adicionar(new Produto(4, "SSD 480GB", "Armazenamento", 249.90m));
            repositorio.Adicionar(new Produto(5, "Webcam", "Periféricos", 159.90m));

            Console.WriteLine("TODOS OS PRODUTOS: ");
            foreach (Produto p in repositorio.ListarTodos())
                Console.WriteLine($"ID: {p.Id} | Nome: {p.Nome} | Categoria: {p.Categoria} | Preço: R$ {p.Preco:F2}");

            Console.WriteLine("\nBUSCA POR CATEGORIA: Periféricos: ");
            foreach (Produto p in repositorio.BuscarPorCategoria("Periféricos"))
                Console.WriteLine($"ID: {p.Id} | Nome: {p.Nome} | Preço: R$ {p.Preco:F2}");
        }

        public static void At3()
        {
            RepositorioProduto repositorio = new RepositorioProduto();

            repositorio.Adicionar(new Produto(1, "Mouse", "Periféricos", 89.90m));
            repositorio.Adicionar(new Produto(2, "Cadeira Gamer", "Móveis", 1299.90m));
            repositorio.Adicionar(new Produto(3, "Headset", "Áudio", 199.90m));

            Console.WriteLine("BUSCA COM ID EXISTENTE: ");
            try
            {
                Produto p = repositorio.BuscarPorId(2);
                Console.WriteLine($"Encontrado: {p.Nome} | Categoria: {p.Categoria} | Preço: R$ {p.Preco:F2}");
            }
            catch (ProdutoNaoEncontradoException ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }

            Console.WriteLine("\nBUSCA COM ID INEXISTENTE: ");
            try
            {
                Produto p = repositorio.BuscarPorId(99);
                Console.WriteLine($"Encontrado: {p.Nome}");
            }
            catch (ProdutoNaoEncontradoException ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
        }

        public static void ExibirTabela(List<Produto> produtos)
        {
            var tabela = new ConsoleTable("Id", "Nome", "Categoria", "Preço");

            foreach (Produto p in produtos.OrderBy(p => p.Preco))
                tabela.AddRow(p.Id, p.Nome, p.Categoria, $"R$ {p.Preco:F2}");

            tabela.Write();
        }

        public static void At4()
        {
            RepositorioProduto repositorio = new RepositorioProduto();

            repositorio.Adicionar(new Produto(1, "Mouse", "Periféricos", 89.90m));
            repositorio.Adicionar(new Produto(2, "Cadeira Gamer", "Móveis", 1299.90m));
            repositorio.Adicionar(new Produto(3, "Headset", "Áudio", 199.90m));
            repositorio.Adicionar(new Produto(4, "SSD 480GB", "Armazenamento", 249.90m));
            repositorio.Adicionar(new Produto(5, "Webcam", "Periféricos", 159.90m));

            ExibirTabela(repositorio.ListarTodos());
        }

        public async static Task At5()
        {
            CotacaoService servico = new CotacaoService();
            try
            {
                decimal cotacao = await servico.ObterCotacaoDolarAsync();
                Console.WriteLine($"Cotação do dólar: R$ {cotacao:F2}");
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Erro ao buscar cotação: {ex.Message}");
            }
        }

        public async static Task AtExtra()
        {
            RepositorioProduto repositorio = new RepositorioProduto();
            repositorio.Adicionar(new Produto(1, "Mouse", "Periféricos", 89.90m));
            repositorio.Adicionar(new Produto(2, "Cadeira Gamer", "Móveis", 1299.90m));
            repositorio.Adicionar(new Produto(3, "Headset", "Áudio", 199.90m));
            repositorio.Adicionar(new Produto(4, "SSD 480GB", "Armazenamento", 249.90m));
            repositorio.Adicionar(new Produto(5, "Webcam", "Periféricos", 159.90m));

            CotacaoService cotacaoService = new CotacaoService();

            bool sair = false;
            while (!sair)
            {
                Console.Clear();
                Console.WriteLine("1 - Listar todos os produtos");
                Console.WriteLine("2 - Buscar por categoria");
                Console.WriteLine("3 - Buscar por Id");
                Console.WriteLine("4 - Ver preços em dólar");
                Console.WriteLine("5 - Salvar catálogo em JSON");
                Console.WriteLine("x - Sair");
                Console.Write("Escolha: ");
                string entrada = Console.ReadLine();

                Console.Clear();
                switch (entrada)
                {
                    case "1":
                        ExibirTabela(repositorio.ListarTodos());
                        break;

                    case "2":
                        Console.Write("Digite a categoria: ");
                        string categoria = Console.ReadLine();
                        List<Produto> resultado = repositorio.BuscarPorCategoria(categoria);
                        if (resultado.Count == 0)
                            Console.WriteLine("Nenhum produto encontrado.");
                        else
                            ExibirTabela(resultado);
                        break;

                    case "3":
                        Console.Write("Digite o Id: ");
                        if (int.TryParse(Console.ReadLine(), out int id))
                        {
                            try
                            {
                                Produto p = repositorio.BuscarPorId(id);
                                Console.WriteLine($"ID: {p.Id} | Nome: {p.Nome} | Categoria: {p.Categoria} | Preço: R$ {p.Preco:F2}");
                            }
                            catch (ProdutoNaoEncontradoException ex)
                            {
                                Console.WriteLine($"Erro: {ex.Message}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Id inválido.");
                        }
                        break;

                    case "4":
                        try
                        {
                            decimal cotacao = await cotacaoService.ObterCotacaoDolarAsync();
                            Console.WriteLine($"Cotação atual: R$ {cotacao:F2}\n");
                            foreach (Produto p in repositorio.ListarTodos().OrderBy(p => p.Preco))
                                Console.WriteLine($"{p.Nome}: US$ {(p.Preco / cotacao):F2}");
                        }
                        catch (HttpRequestException ex)
                        {
                            Console.WriteLine($"Erro ao buscar cotação: {ex.Message}");
                        }
                        break;

                    case "5":
                        string json = JsonConvert.SerializeObject(repositorio.ListarTodos(), Formatting.Indented);
                        File.WriteAllText("catalogo.json", json);
                        Console.WriteLine("Catálogo salvo em catalogo.json!");
                        break;

                    case "x":
                        sair = true;
                        break;

                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }

                if (!sair)
                {
                    Console.Write("\nDigite ENTER para continuar...");
                    Console.ReadLine();
                }
            }
        }
    }
}
