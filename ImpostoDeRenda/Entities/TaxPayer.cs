using ImpostoDeRenda.Entities.Exceptions;
using System.Globalization;

namespace ImpostoDeRenda.Entities
{
    abstract class TaxPayer
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        protected TaxPayer()
        {
        }

        protected TaxPayer(string name, double anualIncome)
        {
            if (anualIncome <= 0)
            {
                throw new DomainException("Erro: ganho anual inválido");
            }

            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double Tax();

        public override string ToString()
        {
            return $"{Name}: R$ {Tax().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
