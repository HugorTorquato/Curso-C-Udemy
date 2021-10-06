using Enum_Exec1.Entities.Enum;
using System.Collections.Generic;

namespace Enum_Exec1.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public Enumm WorkerLevel { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public List<Contract> Contracts { get; set; } = new List<Contract>();
        // Fazer uma lista de contratos ( Jã que um pode ter vários )
        // Já instancia para não ter chance de vir nulo

        public Worker ()
        {
        }

        public Worker(string name, Enumm workerLevel, double baseSalary, Department department)
        {
            // Sempre que tiver uma associação apra muitos, não inclui essa propiedade no construtor
            Name = name;
            WorkerLevel = workerLevel;
            this.BaseSalary = baseSalary;
            Department = department;
        }

        public void AddContract(Contract contract)
        {
            Contracts.Add(contract); 
            // Sempre que quiser adicionar um contrado na lista do trabalhador
            // Tem de chamar essa função
        }

        public void RemoveContract(Contract contract)
        {
            Contracts.Remove(contract);
            // Sempre que quiser adicionar um contrado na lista do trabalhador
            // Tem de chamar essa função
        }

        public double Income(int year, int month)
        {
            // Um trabalhador tem uma lista de contratos assiados a ele
            // Logo, teremos de percorrer essa lista para que consiga obter o número total
            // de remoneração que ele vai receber

            double sum = BaseSalary;

            foreach (Contract contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }

            return sum;
        }

        public override string ToString()
        {
            return Name
                + ", "
                + WorkerLevel
                + ", "
                + BaseSalary;
        }
    }
}
