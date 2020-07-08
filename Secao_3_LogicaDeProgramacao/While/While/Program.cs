using System;
using System.Globalization;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Se repete enquanto a ocndição for verdadeira
             * 
             * Estrutura do WHILE
             * 
             * while ( condição ) {
             *  comando 1
             *  comando 2
             * }
            */

            Console.Write("Digite um número");
            double aa = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (aa >= 0.0)
            {
                double raiz = Math.Sqrt(aa);
                Console.WriteLine("Raiz " + raiz.ToString("F3", CultureInfo.InvariantCulture));

                Console.Write("Digite um número");
                
                aa = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            Console.WriteLine("Numero negativo" );
        }
    }
}
