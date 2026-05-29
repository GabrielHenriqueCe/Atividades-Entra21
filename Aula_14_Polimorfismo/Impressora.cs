using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_14_Polimorfismo
{
    internal class Impressora
    {
        private string _texto { get; set; }
        private int _vezes { get; set; }
        private string _cor { get; set; }

        public string Texto
        {
            get { return _texto; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                { Console.WriteLine("Valor não pode ser vazio"); }
                else
                    _texto = value;
            }
        }
        public int Vezes
        {
            get { return _vezes; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("O valor nao pode ser negativo");
                }
                else
                    _vezes = value;
            }
        }

        public string Cor
        {
            get { return _cor; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                { Console.WriteLine("Valor não pode ser vazio"); }
                else
                    _cor = value;
            }
        }
        public void Imprimir(string texto) 
        { Console.WriteLine($"{Texto} "); }
        public void Imprimir(string texto, int vezes) 
        { Console.WriteLine($"{Texto}   {Vezes}"); }
        public void Imprimir(string texto, int vezes, string cor)
        { Console.WriteLine($"{Texto}   {Vezes}     {Cor}"); }
}
}
