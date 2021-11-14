using System;
using System.Collections.Generic;
using System.Text;

namespace Exec_Resolvido_2.Entities
{
    class Circle : Shape
    {
        public double Radious { get; set; }

        public Circle(Color color, double radious) : base(color)
        {
            Radious = radious;
        }
        public override double area()
        {
            return Math.PI * Radious * Radious;
        }
    }
}
