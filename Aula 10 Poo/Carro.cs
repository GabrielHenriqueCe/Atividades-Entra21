namespace Aula_10_Poo
{
    class Carro
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public decimal Valor { get; set; }
        public bool EhNovo { get; set; }
        public int Km { get; set; }

        public bool EhCarroNovo()
        {
            if (Km == 0)
            {
                Console.WriteLine("O carro é novo Zero Km.");
                EhNovo = true;
                return true;
            }
            else
            {
                Console.WriteLine("O carro é usado.");
                EhNovo = false;
                return false;
            }
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Valor: {Valor}");
            Console.WriteLine($"Km: {Km}");

            EhCarroNovo();
            Console.WriteLine();
        }

        public static void Atividade1()
        {
            Carro[] carro = new Carro[10];

            carro[0] = new Carro()
            {
                Marca = "Renault",
                Modelo = "Kwid",
                Valor = 80000,
                Km = 1500
            };

            carro[0].ExibirInformacoes();
        }
    }
}