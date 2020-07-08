using System;

namespace Exec_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o Valor do raio do circulo");
            double raio = double.Parse(Console.ReadLine());

            double Area = Math.PI * Math.Pow(raio, 2);

            Console.WriteLine($" A parea do circulo é: {Area:F4}");

        }
    }
}
