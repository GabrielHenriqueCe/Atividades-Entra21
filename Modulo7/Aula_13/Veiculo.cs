using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_13
{
    internal class Veiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }

        public virtual void ExibirInfo()
        {

            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
        }

        public Veiculo(string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
        }
    }
}
