using System;
using System.ComponentModel;
using System.Reflection;
using Utilities;
using static Utilities.Helper;

namespace Utilities
{
    public class Utils
    {
        #region Leitura de Input

        public static string LerStringObrigatoria(string mensagem)
        {
            Console.Write(mensagem);

            string input = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(input))
            {
                Console.Write("Campo obrigatório. Digite novamente: ");
                input = Console.ReadLine();
            }

            return input;
        }

        public static int LerInt(string mensagem, int min = int.MinValue, int max = int.MaxValue)
        {
            Console.Write(mensagem);

            string input = Console.ReadLine();

            int valor;

            while (!int.TryParse(input, out valor) ||
                   valor < min ||
                   valor > max)
            {
                Console.Write("Entrada inválida. Digite um número válido: ");
                input = Console.ReadLine();
            }

            return valor;
        }

        public static decimal LerDecimal(string mensagem, decimal min = decimal.MinValue, decimal max = decimal.MaxValue)
        {
            Console.Write(mensagem);

            string input = Console.ReadLine();

            decimal valor;

            while (!decimal.TryParse(input, out valor) ||
                   valor < min ||
                   valor > max)
            {
                Console.Write("Entrada inválida. Digite um número válido: ");
                input = Console.ReadLine();
            }

            return valor;
        }

        public static byte LerByte(string mensagem, byte min = byte.MinValue, byte max = byte.MaxValue)
        {
            Console.Write(mensagem);

            string input = Console.ReadLine();

            byte valor;

            while (!byte.TryParse(input, out valor) ||
                   valor < min ||
                   valor > max)
            {
                Console.Write("Entrada inválida. Digite um número válido: ");
                input = Console.ReadLine();
            }

            return valor;
        }

        public static float LerFloat(string mensagem, float min = float.MinValue, float max = float.MaxValue)
        {
            Console.Write(mensagem);

            string input = Console.ReadLine();

            float valor;

            while (!float.TryParse(input, out valor) ||
                   valor < min ||
                   valor > max)
            {
                Console.Write("Entrada inválida. Digite um número válido: ");
                input = Console.ReadLine();
            }

            return valor;
        }

        public static T? LerOpcao<T>() where T : struct
        {
            while (true)
            {
                ConsoleKeyInfo first = Console.ReadKey(false);

                if (first.Key == ConsoleKey.Escape)
                    return default;

                string input = first.KeyChar + Console.ReadLine();

                if (int.TryParse(input, out int opcao))
                {
                    T valor = (T)Enum.ToObject(typeof(T), opcao);

                    if (Enum.IsDefined(typeof(T), valor))
                        return valor;
                }

                Console.WriteLine("Opção inválida, digite uma opção válida.");
            }
        }

        #endregion

        #region Menu com Cursor

        public static int SelecionarComCursorAux(
            int atual,
            int min,
            int max,
            ConsoleKey tecla,
            bool aceitaNumericos = true,
            bool aceitaHorizontal = false)
        {
            if (tecla == ConsoleKey.W || tecla == ConsoleKey.UpArrow)
                return Math.Max(min, atual - 1);

            if (tecla == ConsoleKey.S || tecla == ConsoleKey.DownArrow)
                return Math.Min(max, atual + 1);

            if (aceitaHorizontal &&
                (tecla == ConsoleKey.A || tecla == ConsoleKey.LeftArrow))
            {
                return Math.Max(min, atual - 1);
            }

            if (aceitaHorizontal &&
                (tecla == ConsoleKey.D || tecla == ConsoleKey.RightArrow))
            {
                return Math.Min(max, atual + 1);
            }

            if (aceitaNumericos &&
                int.TryParse(tecla.ToString().Replace("D", ""), out int num))
            {
                num--;

                if (num >= min && num <= max)
                    return num;
            }

            return atual;
        }

        public static string SelecionarComCursor(string[] opcoes, bool aceitaNumericos = true, bool aceitaHorizontal = false)
        {
            int selecionado = 0;

            while (true)
            {
                Console.Clear();

                for (int i = 0; i < opcoes.Length; i++)
                {
                    if (i == selecionado)
                        Console.WriteLine($"▶ {opcoes[i]}");
                    else
                        Console.WriteLine($"  {opcoes[i]}");
                }

                ConsoleKeyInfo tecla = Console.ReadKey(true);

                if (tecla.Key == ConsoleKey.Enter)
                    break;

                selecionado = SelecionarComCursorAux(
                    selecionado,
                    0,
                    opcoes.Length - 1,
                    tecla.Key,
                    aceitaNumericos,
                    aceitaHorizontal
                );
            }

            return opcoes[selecionado];
        }

        public static T? SelecionarOpcao<T>(bool aceitaNumericos = true, bool aceitaHorizontal = false) where T : struct, Enum
        {
            T[] opcoes = Enum.GetValues<T>();

            int selecionado = 0;

            while (true)
            {
                Console.Clear();

                for (int i = 0; i < opcoes.Length; i++)
                {
                    string descricao = GetDescricao(opcoes[i]);

                    if (i == selecionado)
                        Console.WriteLine($"▶ {i + 1}. {descricao}");
                    else
                        Console.WriteLine($"  {i + 1}. {descricao}");
                }

                ConsoleKeyInfo tecla = Console.ReadKey(true);

                if (tecla.Key == ConsoleKey.Enter)
                    return opcoes[selecionado];

                if (tecla.Key == ConsoleKey.Escape)
                    return null;

                selecionado = SelecionarComCursorAux(
                    selecionado,
                    0,
                    opcoes.Length - 1,
                    tecla.Key,
                    aceitaNumericos,
                    aceitaHorizontal
                );
            }
        }

        #endregion

        #region Utilitários

        public static void PausaParaLer()
        {
            Console.WriteLine("\nPressione ENTER para continuar...");
            Console.ReadLine();
            Console.Clear();
        }

        public static void AlertaLimiteCadastro(string mensagem)
        {
            Console.WriteLine("\n⚠️ ALERTA ⚠️");
            Console.WriteLine($"{mensagem}\n");
        }

        #endregion
    }
}