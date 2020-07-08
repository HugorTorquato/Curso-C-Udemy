using System;
using System.Globalization;

namespace Exerc_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite os dois valores para serem somados");

            string[] vet = Console.ReadLine().Split(' ');

            double n1 = double.Parse(vet[0]);
            double n2 = double.Parse(vet[1]);

            double resultado = (double)n1 + n2;

            Console.WriteLine($"Foi realizada a soma entre os dois números, resultado : {resultado:F2}");






        }
    }
}
