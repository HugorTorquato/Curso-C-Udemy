using System;
using System.Globalization;
using System.Collections.Generic;
using Exec_Resolvido_2.Entities;

namespace Exec_Resolvido_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> li = new List<Shape>();

            Console.Write("Enter thenumber of shapes :");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                Console.Write("Rectangule or Circule ( R/C ) ? ");
                char form = char.Parse(Console.ReadLine());

                Console.Write("Color (BLACK, BLUE, RED) ? ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                switch (form)
                {
                    case 'R':
                        Console.Write("Width : ");
                        double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Console.Write("heigth : ");
                        double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        li.Add(new Rectangle(color, width, height));
                        break;

                    case 'C':
                        Console.Write("Radious : ");
                        double radious = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        li.Add(new Circle(color, radious));
                        break;
                }                    
            }

            Console.WriteLine("");

            foreach(Shape s in li)
            {
                Console.WriteLine(s.area().ToString("F2", CultureInfo.InvariantCulture));
            }

        }
    }
}
