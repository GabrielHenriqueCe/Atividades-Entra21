namespace Aula_16
{
    internal class Atividades
    {
        public static void At1()
        {
            var nome = new List<Pessoa>
            {
                new Pessoa("Gabriel"),
                new Pessoa("José"),
                new Pessoa("Ana"),
                new Pessoa("Eduardo"),
                new Pessoa("Adrian")
            };
            Console.WriteLine("Lista com as pessoas cadastradas\n");
            ExibirNome(nome);

            nome.Add(new Pessoa("Everson"));
            nome.Add(new Pessoa("Henrique"));
            Console.WriteLine("\nLista adicionando duas pessoas\n");
            ExibirNome(nome);

            var deletar = nome.FirstOrDefault(p => p.Nome == "Gabriel");
            nome.Remove(deletar);
            Console.WriteLine("\nLista deletando Gabriel\n");
            ExibirNome(nome);

            Console.WriteLine($"\nQuantidade de nomes: {nome.Count()}\n");

            Console.WriteLine("Ja foi percorrido a lista acima três vezes em estados diferentes, não vou repetir.");
        }

        public static void ExibirNome(List<Pessoa> nome)
        {
            foreach (Pessoa nomes in nome)
                Console.WriteLine($"{nomes.Nome}");
        }

        public static void At2()
        {
            var frutas = new Dictionary<string, int>
            {
                {"Maça", 3},
                {"Banana", 7},
                {"Laranja", 5}
            };

            Console.WriteLine("Dictionary cadastrado\n");
            ExibirDictionary(frutas);

            frutas["Uva"] = 10;

            Console.WriteLine("\nAdicionado Uva no cadastro\n");
            ExibirDictionary(frutas);

            Console.WriteLine($"\nQuantidades de Bananas: {frutas["Banana"]}");

            bool existe = frutas.ContainsKey("Manga");
            if (existe)
            {
                Console.WriteLine("\nManga existe");
            }
            else
            {
                Console.WriteLine("\nManga não existe");
            }

            Console.WriteLine("\nJa percorri a lista acima, não vou mostrar novamente!");
        }
        public static void ExibirDictionary(Dictionary<string, int> frutas)
        {
            foreach (var f in frutas)
                Console.WriteLine($"{f.Key} contém {f.Value} unidades.");
        }

        public static void At3()
        {
            var numeros = new List<int>
            {
                4, 17, 3, 22, 9, 31, 6, 14, 28
            };
            Console.Write("Números maiores que Dez: ");
            var maiorQueDez = numeros.Where(p => p > 10).ToList();
            ExibirListInt(maiorQueDez);

            Console.Write("\n\nNúmeros Pares: ");
            var numeroPar = numeros.Where(p => p % 2 == 0).ToList();
            ExibirListInt(numeroPar);

            Console.Write("\n\nNúmeros Pares: ");
            var qtdMaiorQueQuinze = numeros.Where(p => p > 15).ToList();
            Console.Write($"Quantos maior que 15: {qtdMaiorQueQuinze.Count()}");
        }

        public static void ExibirListInt( List<int> numeros )
        {
            foreach (var m in numeros)
            {
                if (m == numeros.Last())
                    Console.Write($"{m}.");
                else
                    Console.Write($"{m}, ");
            }
        }

        public static void At4()
        {
            var nomes = new List<string>
            {
                "ana", "carlos", "beartiz", "diego", "eva"
            };

            Console.Write("Tudo maiúsculo: ");
            var maiusculo = nomes.Select(p => p.ToUpper()).ToList();
            ExibirListString(maiusculo);

            Console.Write("\n\nOrdem alfabética: ");
            var ordenamAlfabetica = nomes.OrderBy(p => p).ToList();
            ExibirListString(ordenamAlfabetica);

            Console.Write("\n\nDo último ao primeiro: ");
            var ordenamDescendente = nomes.OrderByDescending(p => p).ToList();
            ExibirListString(ordenamDescendente);

        }

        public static void ExibirListString(List<string> str)
        {
            foreach (var s in str)
            {
                if (s == str.Last())
                    Console.Write($"{s}.");
                else
                    Console.Write($"{s}, ");
            }
        }

        public static void At5()
        {
            var produto = new List<Produto>
            {
                new Produto("Mouse", 49.99),
                new Produto("Teclado", 59.99),
                new Produto("Monitor", 899.99),
                new Produto("Headset", 149.99),
                new Produto("Webcam", 199.99),
                new Produto("Mousepad", 29.99)
            };

            var precoMaiorQueVinte = produto.Where(p => p.Preco > 20).ToList();
            Console.WriteLine("Produtos com preço maior que 20:");
            ExibirProduto(precoMaiorQueVinte);

            var ordemAlfabetica = produto.OrderBy(p => p.Nome).ToList();
            Console.WriteLine("\nProdutos por ordem alfabética:");
            ExibirProduto(ordemAlfabetica);

            var somaProdutos = produto.Sum(p => p.Preco);
            var mediaProdutos = produto.Average(p => p.Preco);

            Console.WriteLine($"\nA soma do preço dos produtos é {somaProdutos:F2} e a média é {mediaProdutos:F2}");
        }

        public static void ExibirProduto(List<Produto> lista)
        {
            foreach (var p in lista)
                Console.WriteLine($"{p.Nome}: R${p.Preco}");
        }

        public static void ExibirProdutoCompleto(List<Produto> lista)
        {
            foreach (var p in lista)
                Console.WriteLine($"Nome:{p.Nome}   Preço: R${p.Preco:F2}   Categoria:{p.Categoria}     Quantidade:{p.Estoque}");
        }

        public static void AtExtra()
        {
            var produto = new List<Produto>
            {
                new Produto("Mouse", 49.99, "Periférico", 15),
                new Produto("Teclado", 59.99, "Periférico", 3),
                new Produto("Mousepad", 29.99, "Periférico", 2),
                new Produto("Monitor", 899.99, "Vídeo", 5),
                new Produto("Webcam", 199.99, "Vídeo", 4),
                new Produto("Headset", 149.99, "Áudio", 8),
                new Produto("Caixa de Som", 199.99, "Áudio", 1),
                new Produto("Microfone", 249.99, "Áudio", 10)
            };

            Console.WriteLine("Produtos com estoque <5: \n");
            var estoqueBaixo = produto.Where(p => p.Estoque < 5).ToList();
            ExibirProdutoCompleto(estoqueBaixo);

            var produtoMaisCaro = produto.MaxBy(p => p.Preco);
            Console.WriteLine($"\nO produto mais caro é o {produtoMaisCaro.Nome} com o valor de {produtoMaisCaro.Preco:F2}");

            var produtoMaisBarato = produto.MinBy(p => p.Preco);
            Console.WriteLine($"\nO produto mais barato é o {produtoMaisBarato.Nome} com o valor de {produtoMaisBarato.Preco:F2}");

            var valorTotal = produto.Sum(p => p.Preco)*produto.Sum(p => p.Estoque);
            Console.WriteLine($"\nO valor total em produtos do estoque é {valorTotal:F2}");
        }
    }
}
