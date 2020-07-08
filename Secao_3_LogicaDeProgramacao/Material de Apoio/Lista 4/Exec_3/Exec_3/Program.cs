using System;
using System.Globalization;

namespace Exec_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantidade de casos? ");
            int limit = int.Parse(Console.ReadLine());

            for (int i = 0; i < limit; i++)
            {
                Console.WriteLine(" ");
                Console.WriteLine(" Digite 3 valores Reais com uma casa decimal ");
                string[] vet = Console.ReadLine().Split(' ');
                double n1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
                double n2 = double.Parse(vet[1], CultureInfo.InvariantCulture);
                double n3 = double.Parse(vet[2], CultureInfo.InvariantCulture);

                /* Peso de cada valor
                 * PRIMEIRO - 2
                 * SEGUNDO - 3 
                 * TERCEIRO - 5
                 */

                double media_ponderada = ((n1 * 2) + (n2 * 3) + (n3 * 5)) / 10;
                Console.WriteLine(media_ponderada);

            }
        }
    }
}
