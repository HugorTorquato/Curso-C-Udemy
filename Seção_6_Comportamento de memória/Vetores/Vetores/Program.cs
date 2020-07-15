using System;
using System.Globalization;
using System.Linq;

namespace Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com a quantidade de elementos");
            int n = int.Parse(Console.ReadLine());

            double[] vet = new double[n];

            for( int x=0; x<n; x++)
            {
                vet[x] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double soma = vet.Sum()/vet.Length;

            Console.WriteLine(soma + " Média das idadea");





            

        }
    }
}
