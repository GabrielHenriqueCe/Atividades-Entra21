using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Text;
namespace Aula_11_Poo
{
    internal class Produto
    {
        #region Propriedades

        public decimal Valor { get; set; }
        public string Nome { get; set; }

        #endregion

        #region Metodos

        public void ExibirInformacoes()
        {
            Console.WriteLine($"O produto {Nome} custa {Valor}.\n");
        }

        #endregion

    }
}
