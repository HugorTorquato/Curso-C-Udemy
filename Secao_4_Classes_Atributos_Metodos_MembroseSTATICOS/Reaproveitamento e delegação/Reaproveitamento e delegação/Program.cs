using System;
using System.Globalization;

namespace Reaproveitamento_e_delegação
{
    class Program
    {
        static void Main(string[] args)
        {            
            //Declaração
            Triangulo x, y;

            //Instanciação
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triangulo X : ");

            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triangulo Y : ");

            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            /*
            double p = (x.A + x.B + x.C) / 2.0;
            double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

            p = (y.A + y.B + y.C) / 2.0;
            double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));
            */

            double areaX = x.Area();
            double areaY = y.Area();

            Console.WriteLine(" áREA DE X = " + areaX.ToString("f4", CultureInfo.InvariantCulture));
            Console.WriteLine(" áREA DE y = " + areaY.ToString("f4", CultureInfo.InvariantCulture));

            if (areaX > areaY) Console.WriteLine(" Maior área é do X");
            else Console.WriteLine(" Maior área é do Y");

        }
    }
}

