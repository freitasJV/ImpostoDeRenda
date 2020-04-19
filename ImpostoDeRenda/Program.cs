using System;
using System.Globalization;

namespace ImpostoDeRenda
{
    class Program
    {
        /// <summary>
        /// Os cálculos foram feitos com a seguinte tabela
        /// Faixa de Renda                  Imposto de renda (%)
        /// de 0.00 a R$ 2000.00            Isento
        /// de R$ 2000.01 até R$ 3000.00    8%
        /// de R$ 3000.01 até R$ 4500.00    18%
        /// Acima de R$ 4500.00             28%
        /// 
        /// Lembre que, se o salário for R$ 3002.00, a taxa que incide é de 8% apenas sobre R$ 1000.00, pois a faixa de
        /// salário que fica de R$ 0.00 até R$ 2000.00 é isenta de Imposto de Renda.Neste caso a taxa é
        /// de 8% sobre R$ 1000.00 + 18% sobre R$ 2.00, o que resulta em R$ 80.36 no total. 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o salário:");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double impostoDevido;

            if (salario < 0)
                Console.WriteLine("Valor incorreto");
            else {
                if (salario <= 2000)
                    impostoDevido = 0;
                else if (salario <= 3000)
                    impostoDevido = (salario - 2000) * 0.08;
                else if (salario <= 4500)
                    impostoDevido = (salario - 3000) * 0.18 + 1000 * 0.08;
                else
                    impostoDevido = (salario - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;

                if (impostoDevido == 0.0)
                {
                    Console.WriteLine("Isento");
                }
                else
                {
                    Console.WriteLine($"Imposto devido: R$ {impostoDevido.ToString("F2", CultureInfo.InvariantCulture)}");
                }
            }


        }
    }
}
