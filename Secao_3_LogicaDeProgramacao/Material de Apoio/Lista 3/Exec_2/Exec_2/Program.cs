using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Exec_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite as coordenadas");
            string[] Cords = Console.ReadLine().Split(' ');

            double n1 = double.Parse(Cords[0], CultureInfo.InvariantCulture);
            double n2 = double.Parse(Cords[1], CultureInfo.InvariantCulture);

            if (n1 > 0 && n2 > 0) Console.WriteLine("Primeiro");
            else if (n1 > 0 && n2 < 0) Console.WriteLine("Quarto");
            else if (n1 < 0 && n2 < 0) Console.WriteLine("Terceiro");
            else if (n1 < 0 && n2 > 0) Console.WriteLine("Segundo");
            else if (n1 == 0 && n2 == 0) Console.WriteLine("zero");
            else if (n1 == 0) Console.WriteLine("Eixo X");
            else if (n2 == 0) Console.WriteLine("Eixo Y");



        }
    }
}
