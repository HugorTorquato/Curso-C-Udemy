using System;
using System.Globalization;

namespace Exec_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo Ret = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retângulo: ");

            Ret.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Ret.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(" Área = " + (Ret.Area()).ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(" Perímetro = " + (Ret.Perimetro()).ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(" Diagonal = " + (Ret.Diagonal()).ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
