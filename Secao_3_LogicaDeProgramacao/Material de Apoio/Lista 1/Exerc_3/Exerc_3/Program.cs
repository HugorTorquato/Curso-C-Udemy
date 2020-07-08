using System;
using System.Globalization;

namespace Exerc_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com quatro valores inteiros ( Um por linha)");
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            int D = int.Parse(Console.ReadLine());

            int Diff = A * B - C * D;
            Console.WriteLine("A diferença do protudo entre os números corresponde a : " + Diff.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
