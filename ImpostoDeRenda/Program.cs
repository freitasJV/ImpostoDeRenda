using ImpostoDeRenda.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace ImpostoDeRenda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();

            Console.Write("Digite o número de contribuintes: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                bool tipoValido = false;
                string tipo;
                do
                {
                    Console.Write("Pessoa física ou jurídica (F/J): ");
                    tipo = Console.ReadLine();
                    if (!tipo.ToUpper().Equals("J") && !tipo.ToUpper().Equals("F"))
                    {
                        Console.WriteLine("Por favor, digite um tipo válido");
                    }
                    else
                    {
                        tipoValido = true;
                    }

                } while (!tipoValido);

                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Ganho anual: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (tipo.ToUpper().Equals("J"))
                {
                    Console.Write("Número de funcionários: ");
                    int numberOfEmoployees = int.Parse(Console.ReadLine());
                    list.Add(new Company(numberOfEmoployees, name, anualIncome));
                }
                else
                {
                    Console.Write("Despesas médicas: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Individual(healthExpenditures, name, anualIncome));
                }


            }

            Console.WriteLine();
            Console.WriteLine("Impostos a receber:");

            foreach (TaxPayer t in list)
            {
                Console.WriteLine(t);
            }

            double total = list.Sum(x => x.Tax());

            Console.WriteLine($"Total: R${total}");
        }
    }
}
