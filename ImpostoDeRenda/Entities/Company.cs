using ImpostoDeRenda.Entities.Exceptions;

namespace ImpostoDeRenda.Entities
{
    class Company : TaxPayer
    {
        public int NumberOfEmployees { get; set; }

        public Company()
        {
        }

        public Company(int numberOfEmployees, string name, double anualIncome) : base (name, anualIncome)
        {
            if (numberOfEmployees <= 0)
            {
                throw new DomainException("Erro: número de funcionários inválido");
            }

            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            if (NumberOfEmployees > 10)
            {
                return AnualIncome * 0.14;
            }
            else
            {
                return AnualIncome * 0.16;
            }
        }
    }
}
