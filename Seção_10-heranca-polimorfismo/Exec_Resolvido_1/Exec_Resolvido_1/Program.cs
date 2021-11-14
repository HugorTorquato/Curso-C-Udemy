using System;
using Exec_Resolvido_1.Entities;
using System.Collections.Generic;
using System.Globalization;

namespace Exec_Resolvido_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> li = new List<Employee>();
            // a lista é declarada como Employee mas tem um polimorfismo no quesito payment.... no caso de ser um outsourceemployee
            // a função payment que vai star em vigência será a da classe outsourceemployee

            Console.Write("Enter the number of employees : ");
            int Num = int.Parse(Console.ReadLine());

            for (int i=0; i < Num; i++)
            {
                Console.Write("Outsourced (y/n): ");
                char outt = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value por Hour: ");
                double valueperHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (outt == 'y') 
                {
                    Console.Write("Addicional Charges : ");
                    double aditional = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    li.Add(new OutsourceEmployee(name, hours, valueperHour, aditional));
                }
                else
                {
                    li.Add(new Employee(name, hours, valueperHour));
                }
            }

            foreach( Employee emp in li)
            {
                Console.WriteLine(emp.Name + " - $ " + emp.Payment().ToString("F2",CultureInfo.InvariantCulture));
            }
        }
    }
}
