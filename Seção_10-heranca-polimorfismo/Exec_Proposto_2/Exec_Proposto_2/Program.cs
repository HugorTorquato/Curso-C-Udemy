using System;
using System.Globalization;
using System.Collections.Generic;
using Exec_Proposto_2.Entities;

namespace Exec_Proposto_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> li = new List<TaxPayer>();

            Console.Write(" Enter the number of tax payers :");
            int num = int.Parse(Console.ReadLine());

            for (int i=0; i<num; i++)
            {
                Console.WriteLine("");
                Console.WriteLine("Tax Payer #{0}", i);
                Console.WriteLine("");

                Console.Write("Individual or Company (I/C) ? ");
                char form = char.Parse(Console.ReadLine().ToUpper());

                Console.Write("Name :");
                string name = Console.ReadLine();
                Console.Write("Annual Income :");
                double anualincome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                switch (form)
                {
                    case 'I':
                        Console.Write("Health Expenditures");
                        double healthexpenditudes = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        li.Add(new Individual(name, anualincome, healthexpenditudes));
                        break;

                    case 'C':
                        Console.Write(" Number of employees :");
                        int numberofemployes = int.Parse(Console.ReadLine());
                        li.Add(new Company(name, anualincome, numberofemployes));
                        break;
                }
            }

            Console.WriteLine("");
            foreach(TaxPayer t in li)
            {
                Console.WriteLine(t.Name + ": $ " + t.Tax());
            }
        }
    }
}
