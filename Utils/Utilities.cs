using System;

namespace Utilities
{
    public class Utils
    {
        public static void PausaParaLer()
        {
            Console.WriteLine("\nPressione ENTER para continuar...");
            Console.ReadLine();
            Console.Clear();
        }

        public static void AlertaLimiteCadastro(string mensagem)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("\n⚠️ ALERTA ⚠️");
            Console.WriteLine($"{mensagem}\n");
        }

        public static string LerStringObrigatoria(string mensagem, string mensagemErro)
        {
            Console.Write(mensagem);
            string input = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(input))
            {
                Console.Write(mensagemErro);
                input = Console.ReadLine();
            }
            return input;
        }

        public static decimal LerDecimal(string mensagem, string mensagemErro, decimal min, decimal max)
        {
            Console.Write(mensagem);
            string input = Console.ReadLine();
            decimal valor;
            while (!decimal.TryParse(input, out valor) || valor < min || valor > max)
            {
                Console.Write(mensagemErro);
                input = Console.ReadLine();
            }
            return valor;
        }

        public static byte LerByte(string mensagem, string mensagemErro, byte min, byte max)
        {
            Console.Write(mensagem);
            string input = Console.ReadLine();
            byte valor;
            while (!byte.TryParse(input, out valor) || valor < min || valor > max)
            {
                Console.Write(mensagemErro);
                input = Console.ReadLine();
            }
            return valor;
        }

        public static float LerFloat(string mensagem, string mensagemErro, float min, float max)
        {
            Console.Write(mensagem);
            string input = Console.ReadLine();
            float valor;
            while (!float.TryParse(input, out valor) || valor < min || valor > max)
            {
                Console.Write(mensagemErro);
                input = Console.ReadLine();
            }
            return valor;
        }
    }
}
