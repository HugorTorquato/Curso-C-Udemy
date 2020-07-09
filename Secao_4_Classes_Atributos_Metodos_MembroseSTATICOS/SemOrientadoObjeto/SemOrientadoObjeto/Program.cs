using System;
using System.Globalization;

namespace SemOrientadoObjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            double XA, XB, XC;
            double YA, YB, YC;

            Console.WriteLine("Entre com as medidas do triangulo X : ");

            XA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            XB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            XC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triangulo Y : ");

            YA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            YB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            YC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            double p = (XA + XB + XC) / 2.0;
            double areaX = Math.Sqrt(p * (p - XA) * (p - XB) * (p - XC));

            p = (YA + YB + YC) / 2.0;
            double areaY = Math.Sqrt(p * (p - YA) * (p - YB) * (p - YC));

            Console.WriteLine(" áREA DE X = " + areaX.ToString("f4", CultureInfo.InvariantCulture));
            Console.WriteLine(" áREA DE y = " + areaY.ToString("f4", CultureInfo.InvariantCulture));

            if (areaX > areaY) Console.WriteLine(" Maior área é do X");
            else Console.WriteLine(" Maior Y");

        }
    }
}
