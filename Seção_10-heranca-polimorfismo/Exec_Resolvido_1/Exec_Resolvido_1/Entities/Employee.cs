using System;
using System.Collections.Generic;
using System.Text;

namespace Exec_Resolvido_1.Entities
{
    class Employee
    {
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValePerHour { get; set; }

        public Employee() { }

        public Employee(string name, int hours, double valePerHour)
        {
            Name = name;
            Hours = hours;
            ValePerHour = valePerHour;
        }

        public virtual double Payment()
        {
            return Hours * ValePerHour;
        }
    }
}
