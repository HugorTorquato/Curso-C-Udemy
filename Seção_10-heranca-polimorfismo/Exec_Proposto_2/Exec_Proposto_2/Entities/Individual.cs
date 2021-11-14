using System;
using System.Collections.Generic;
using System.Text;

namespace Exec_Proposto_2.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual(string name, double anualIncome, double healthExpenditures)
            : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            double imposto = 25;

            if(AnualIncome < 20000)
            {
                imposto = 15;
            }

            return AnualIncome * (imposto/100) - (HealthExpenditures / 2);
        }
    }
}
