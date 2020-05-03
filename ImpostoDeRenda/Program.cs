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
                do
                {
                    Console.Write("Pessoa física ou jurídica (F/J): ");
                    string tipo = Console.ReadLine();

                    if (tipo.ToUpper().Equals("J"))
                    {
                        tipoValido = true;
                        Console.Write("Nome: ");
                        string name = Console.ReadLine();
                        Console.Write("Ganho anual: ");
                        double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Console.Write("Número de funcionários: ");
                        int numberOfEmoployees = int.Parse(Console.ReadLine());
                        list.Add(new Company(numberOfEmoployees, name, anualIncome));
                    }
                    else if (tipo.ToUpper().Equals("F"))
                    {
                        tipoValido = true;
                        Console.Write("Nome: ");
                        string name = Console.ReadLine();
                        Console.Write("Ganho anual: ");
                        double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Console.Write("Despesas médicas: ");
                        double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        list.Add(new Individual(healthExpenditures, name, anualIncome));
                    }
                    else
                    {
                        Console.WriteLine("Por favor, digite um tipo válido");
                    }

                } while (!tipoValido);

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
