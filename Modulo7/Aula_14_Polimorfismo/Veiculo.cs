using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_14_Polimorfismo
{
    internal class Veiculo
    {
        private int _movimento { get; set; }
        private string _tipo { get; set; }
        public int Movimento
        {
            get { return _movimento; }
            set { _movimento = value; }
        }
        public string Tipo
        {
            get { return _tipo; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("O campo não pode ser vazio");
                }
                _tipo = value;
            }
        } 
        public virtual void Movimentar()
        {
            for (int i = 0; i < Movimento; i++)
            {
                Console.Write(" ");
            }
            Movimento++;
            Console.Write($"{Tipo}\n");
        }
        public virtual void Mover()
        {
            Console.WriteLine($"{Tipo} está se movendo");
        }
    }
}
