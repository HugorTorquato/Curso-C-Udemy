using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExecLista
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void SalaryRaise(double raise)
        {
            Salary += Salary * raise;
        }


        public override string ToString()
        {
            return Id
                + " ,"
                + Name
                + " , salary: "
                + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
