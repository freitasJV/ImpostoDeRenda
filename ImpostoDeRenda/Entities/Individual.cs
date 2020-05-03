using ImpostoDeRenda.Entities.Exceptions;
using System;

namespace ImpostoDeRenda.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual()
        {
        }

        public Individual(double healthExpenditures, string name, double anualIncome) : base(name, anualIncome)
        {
            if (healthExpenditures <= 0)
            {
                throw new DomainException("Erro: valor de despesas médicas inválido");
            }

            HealthExpenditures = healthExpenditures;
        }
        public override double Tax()
        {

            if (AnualIncome >= 20000)
            {
                return AnualIncome * 0.25 - HealthExpenditures * 0.5;
            }
            else
            {
                return AnualIncome * 0.15 - HealthExpenditures * 0.5;
            }
        }
    }
}
