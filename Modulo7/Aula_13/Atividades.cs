using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_13
{
    internal class Atividades
    {
        public static void At1()
        {
            Carro carro = new Carro(4, "Renault", "Kwid");

            carro.ExibirInfo();
        }

        public static void At2()
        {
            Funcionario funcionario = new Funcionario("Gerente", "Gabriel", 30);

            Console.WriteLine(funcionario.Cargo);
            Console.WriteLine(funcionario.Nome);
            Console.WriteLine(funcionario.Idade);
        }

        public static void At3()
        {
            Circulo circulo = new Circulo { Raio = 14.5 };
            Retangulo retangulo = new Retangulo { Largura = 15, Altura = 10 };

            Console.WriteLine($"A Área do circulo é {circulo.CalcularArea():F2}");
            Console.WriteLine($"A Área do retangulo é {retangulo.CalcularArea():F2}");
        }

        public static double ConverterDouble()
        {
            Console.Write("Digite o valor: ");
            string entrada = Console.ReadLine();
            double numero;
            while (!double.TryParse(entrada, out numero))
            {
                Console.WriteLine("Valor inválido!");
                Console.Write("Digite novamente: ");
                entrada = Console.ReadLine();
            }
            return numero;
        }

        public static void At4()
        {
            CLT clt = new CLT("Gabriel", 0);
            PJ pj = new PJ(0, 0, "Gabriel", 0);

            Console.WriteLine("Salário CLT");
            clt.Salario = ConverterDouble();
            Console.WriteLine($"O Salario do CLT {clt.Nome} é {clt.CalcularSalario()}");

            Console.WriteLine("Valor da Hora PJ");
            pj.ValorHoras = ConverterDouble();

            Console.WriteLine("Horas trabalhadas no mês PJ");
            pj.Horas = ConverterDouble();

            Console.WriteLine($"O Salario do CLT {pj.Nome} é {pj.CalcularSalario()}");
        }

        public static void At5()
        {
            ContaCorrente contaCorrente = new ContaCorrente() { Saldo = 1000, TaxaManutencao = 7.96 };
            ContaPoupanca contaPoupanca = new ContaPoupanca() { Saldo = 1000, TaxaRendimento = 1.01 };

            contaCorrente.TipoDescricao();
            contaPoupanca.TipoDescricao();
        }

        public static void AtExtra()
        {
            Guerreiro guerreiro = new Guerreiro() {Nome = "Guerreiro", Dano = 30, Vida = 100 };
            Mago mago = new Mago() { Nome = "Mago", Dano = 50, Vida = 100, Mana = 40 };
            Arqueiro arqueiro = new Arqueiro() { Nome = "Arqueiro", Dano = 20, Vida = 100, Flecha = 5 };

            List<Personagem> combatentes = new List<Personagem> { guerreiro, mago, arqueiro };

            while (combatentes.Count(c => c.Vida > 0) > 1)
            {
                for (int i = 0; i < combatentes.Count; i++)
                {
                    if (combatentes[i].Vida <= 0) continue;

                    int proximoIndex = (i + 1) % combatentes.Count;
                    while (combatentes[proximoIndex].Vida <= 0 && proximoIndex != i)
                        proximoIndex = (proximoIndex + 1) % combatentes.Count;

                    combatentes[i].Atacar(combatentes[proximoIndex]);

                    if (combatentes.Count(c => c.Vida > 0) == 1)
                    {
                        Personagem vencedor = combatentes.First(c => c.Vida > 0);
                        Console.WriteLine($"{vencedor.Nome} venceu!");
                        return;
                    }
                }
            }
        }
    }
}
