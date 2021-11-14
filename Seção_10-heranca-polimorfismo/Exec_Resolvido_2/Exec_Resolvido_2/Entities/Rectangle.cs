using System;
using System.Collections.Generic;
using System.Text;

namespace Exec_Resolvido_2.Entities
{
    class Rectangle : Shape
    {
        public double Wigth { get; set; }
        public double Height { get; set; }

        public Rectangle(Color color, double wigth,double height) : base(color)
        {
            Wigth = wigth;
            Height = height;
        }

        public override double area()
        {
            return Wigth * Height;
        }
    }
}
