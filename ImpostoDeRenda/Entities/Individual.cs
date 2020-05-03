using System;

namespace ImpostoDeRenda.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual(double healthExpenditures, string name, double anualIncome) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }
        public override double Tax()
        {
            double imposto;

            if (AnualIncome >= 20000)
            {
                imposto = AnualIncome * 0.25;
            }
            else
            {
                imposto = AnualIncome * 0.15;
            }

            return imposto - (HealthExpenditures * 0.5);
        }
    }
}
