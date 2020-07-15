using System;

namespace ModificadorDeParametrosParams
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solução ruim
            //int s1 = Calculator.Sum(2, 3);

            //int s2 = Calculator.Sum(2, 3, 4);

            //int s3 = Calculator.Sum(2, 3, 4, 5);

            // Opção

            /*
             * Usando vetores -> criar uma função soma que recebe um vetr de números somando e percorrendo os valores
             * 
             * Chama no principal
             */

            int s1 = Calculator.Sum(new int[] { 2, 3 });
            int s2 = Calculator.Sum(new int[] { 2, 3, 4 });

            Console.WriteLine(s1);
            Console.WriteLine(s2);

            //usnado modificador de parametro params
            int s3 = Calculator.Sum2( 2, 3 );
            int s4 = Calculator.Sum2(2, 3, 4 );

            Console.WriteLine(s3);
            Console.WriteLine(s4);


        }
    }
}
