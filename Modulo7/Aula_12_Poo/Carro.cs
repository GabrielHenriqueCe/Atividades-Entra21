using System;
using System.Collections.Generic;
using System.Text;
using Utilities;
using static Utilities.Utils;

namespace Aula_12_Poo
{
    internal class Carro
    {
        #region Propriedades
        private string _marca { get; set; }
        private string _modelo { get; set; }
        private int _velocidadeAtual { get; set; }

        public string Marca
        {
            get { return _marca; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A marca do carro não pode ser vazia. Por favor, insira uma marca válida.");
                }
                else
                {
                    _marca = value;
                }
            }
        }

        public string Modelo
        {
            get { return _modelo; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("O modelo do carro não pode ser vazio. Por favor, insira um modelo válido.");
                }
                else
                {
                    _modelo = value;
                }
            }
        }

        public int VelocidadeAtual
        {
            get { return _velocidadeAtual; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A velocidade atual não pode ser negativa. Por favor, insira um valor válido.");
                }
                else
                {
                    _velocidadeAtual = value;
                }
            }
        }

        #endregion

        #region Métodos

        public void Acelerar()
        {
            VelocidadeAtual++;
        }

        public void Frear()
        {
            if (VelocidadeAtual > 0)
                VelocidadeAtual--;
        }

        public string Velocimetro()
        {
            string[] relogios = { "🕛", "🕐", "🕑", "🕒", "🕓", "🕔", "🕕", "🕖", "🕗", "🕘", "🕙" };
            return $"Velocidade atual: {VelocidadeAtual} km/h {relogios[VelocidadeAtual % 10]}";
        }

        #endregion
    }
}