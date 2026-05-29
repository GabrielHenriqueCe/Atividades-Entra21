using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_14_Polimorfismo
{
    internal class Atividades
    {
        public static void Atividade1()
        {
            Veiculo veiculo1 = new Carro { Tipo = "🚗", Movimento = 1 };
            Veiculo veiculo2 = new Aviao { Tipo = "✈️", Movimento = 1 };
            Veiculo veiculo3 = new Barco { Tipo = "⛵", Movimento = 1 };

            List<Veiculo> veiculo = new List<Veiculo> { veiculo1, veiculo2, veiculo3 };
            bool sair = false;
            while (!sair)
            {
                Console.WriteLine("Q: move o carro");
                Console.WriteLine("W: move o avião");
                Console.WriteLine("E: move o barco");
                Console.WriteLine("R: para chamar o Mover da Atividade");
                Console.WriteLine("X: sair");
                ConsoleKeyInfo tecla = Console.ReadKey(true);
                switch (tecla.Key)
                {
                    case ConsoleKey.Q:
                        Console.Clear();
                        veiculo1.Movimentar();
                        break;
                    case ConsoleKey.W:
                        Console.Clear();
                        veiculo2.Movimentar();
                        break;
                    case ConsoleKey.E:
                        Console.Clear();
                        veiculo3.Movimentar();
                        break;
                    case ConsoleKey.R:
                        Console.Clear();
                        foreach (var v in veiculo)
                        { v.Mover(); }
                        break;
                    case ConsoleKey.X:
                        Console.WriteLine("\nVoltando ao menu principal...");
                        sair = true;
                        break;
                }
            }
        }

        public static void Atividade2()
        {
            Impressora impressora = new Impressora { Texto = "Texto", Vezes = 1, Cor = "Verde" };

            impressora.Imprimir(impressora.Texto);
            impressora.Imprimir(impressora.Texto, impressora.Vezes);
            impressora.Imprimir(impressora.Texto, impressora.Vezes, impressora.Cor);
        }
    }
}
