using System;
using Enum_Exec1.Entities;
using Enum_Exec1.Entities.Enum;
using System.Globalization;

namespace Enum_Exec1
{
    // Ler dados de um trabalhador com N contratos, depois solicitar o mes e mostrar qual fofi o salário nesse mÊs
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name :");
            string deptName = Console.ReadLine();

            Console.WriteLine("Enter worker data:");
            Console.Write("Name:");
            string name = Console.ReadLine();

            Console.Write("Level :");
            Enumm level = Enum.Parse<Enumm>(Console.ReadLine());

            Console.Write("Base Salary : ");
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Instanciaros objetos relacionados

            Department dept = new Department(deptName);

            Worker worker = new Worker(name, level, salary, dept); // Usa o objeto instanciado anteriormente

            Console.Write(" How many Contracts to this worker?");
            int num_contracts = int.Parse(Console.ReadLine());

            for (int i = 1; i<=num_contracts; i++)
            {
                Console.WriteLine($"Enter #{i} contract data: "); // $ para funcionar a interpolação {i}
                Console.Write("Date (DD/MM/YYY)");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour:");
                double value_per_hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration(hours):");
                int hours = int.Parse(Console.ReadLine());

                // Instanciamos o contrato
                Contract contract = new Contract(date, value_per_hour, hours);

                // Adicionar aos contratos do trabalhador
                worker.AddContract(contract);
            }

            Console.Write("Enter month and year to calculat income (MM/YYY) :");
            string my = Console.ReadLine();

            // Manipular string para recortar a data

            int m = int.Parse(my.Substring(0, 2));
            int y = int.Parse(my.Substring(3));

            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Department : " + worker.Department.Name); // Navegação entre os objetos
            Console.WriteLine("Income for " + m + " : " + worker.Income(y, m));



        }
    }
}
