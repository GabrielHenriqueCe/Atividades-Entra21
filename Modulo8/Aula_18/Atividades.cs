
using System.Diagnostics;
using System.Text.Json;

namespace Aula_18
{
    internal class Atividades
    {
        static async Task SaudarAsync(string nome)
        {
            await Task.Delay(1000);
            Console.WriteLine($"Olá {nome}, bem vindo ao async/await");
        }
        public async static Task At1()
        {
            await SaudarAsync("Gabriel");
            await SaudarAsync("Henrique");
            await SaudarAsync("Cé");
        }

        public async static Task<double> CalcularMediaAsync(List<int> numeros)
        {
            await Task.Delay(500);

            return numeros.Average();
        }

        public async static Task At2()
        {
            List<int> numeros = new List<int>() { 5, 10, 15, 7, 13 };
            double media = await CalcularMediaAsync(numeros);
            Console.WriteLine($"A média é: {media:F2}");
        }

        public async static Task<int> DividirAsync(int a, int b)
        {
            await Task.Delay(500);
            if (b == 0)
                throw new DivideByZeroException();
            else
                return a / b;
        }

        public async static Task At3Aux(int a, int b)
        {
            try
            {
                double divisao = await DividirAsync(a, b);
                Console.WriteLine($"A divisão é {divisao}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine($"O número não pode ser divisível por zero");
            }
            finally
            {
                Console.WriteLine("Operação concluída");
            }
        }
        public async static Task At3()
        {
            await At3Aux(10, 2);
            await At3Aux(10, 0);
        }

        private static Random rnd = new Random();
        public async static Task<string> SimularDownloadAsync(string arquivo)
        {
            await Task.Delay(rnd.Next(500, 2001));
            return $"{arquivo} baixado";
        }
        public async static Task At4()
        {
            Stopwatch stop = Stopwatch.StartNew();

            string[] resultados = await Task.WhenAll(
                SimularDownloadAsync("relatorio.pdf"),
                SimularDownloadAsync("foto.jpg"),
                SimularDownloadAsync("dados.csv"),
                SimularDownloadAsync("config.json")
            );

            stop.Stop();

            foreach (string resultado in resultados)
                Console.WriteLine(resultado);

            Console.WriteLine($"Tempo total: {stop.Elapsed.TotalSeconds}s");
        }

        private static HttpClient client = new HttpClient();

        public async static Task BuscarPostAsync(int id)
        {
            try
            {
                string url = $"https://jsonplaceholder.typicode.com/posts/{id}";
                string json = await client.GetStringAsync(url);
                Console.WriteLine(json);
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Erro na requisição: {ex.Message}");
            }
        }

        public async static Task At5()
        {
            await BuscarPostAsync(1);
            await BuscarPostAsync(2);
            await BuscarPostAsync(3);
        }

        private async static Task<string> BuscarAsync(string url)
        {
            try
            {
                return await client.GetStringAsync(url);
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Erro ao buscar {url}: {ex.Message}");
                return null;
            }
        }
        public async static Task AtExtra()
        {
            Stopwatch stop = Stopwatch.StartNew();

            Task<string>[] postTasks = new Task<string>[]
            {
                BuscarAsync("https://jsonplaceholder.typicode.com/posts/1"),
                BuscarAsync("https://jsonplaceholder.typicode.com/posts/2"),
                BuscarAsync("https://jsonplaceholder.typicode.com/posts/3")
            };

            Task<string>[] userTasks = new Task<string>[]
            {
                BuscarAsync("https://jsonplaceholder.typicode.com/users/1"),
                BuscarAsync("https://jsonplaceholder.typicode.com/users/2"),
                BuscarAsync("https://jsonplaceholder.typicode.com/users/3")
            };

            string[] posts = await Task.WhenAll(postTasks);
            string[] users = await Task.WhenAll(userTasks);

            stop.Stop();

            Console.WriteLine("POSTS: ");
            foreach (string post in posts)
            {
                if (post == null) continue;
                var json = JsonDocument.Parse(post);
                Console.WriteLine(json.RootElement.GetProperty("title").GetString());
            }

            Console.WriteLine("\nUSUÁRIOS: ");
            foreach (string user in users)
            {
                if (user == null) continue;
                var json = JsonDocument.Parse(user);
                Console.WriteLine(json.RootElement.GetProperty("name").GetString());
            }

            Console.WriteLine($"\nTempo total: {stop.Elapsed.TotalSeconds}s");
        }
    }
}
