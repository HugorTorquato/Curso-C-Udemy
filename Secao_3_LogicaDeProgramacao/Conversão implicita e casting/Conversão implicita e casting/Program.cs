using System;

namespace Conversão_implicita_e_casting
{
    class Program
    {
        static void Main(string[] args)
        {


            float x = 4.5f;

            double y = x; // Conversão implicita

            double a = 5.1;

            //float b = a;

            float c = (float)a;// Casting

            int d = (int)a;// Casting


            Console.WriteLine(y);
            Console.WriteLine(c);
            Console.WriteLine(d);


            int e = 5;
            int f = 2;

            double resultado = e / f;          // Por fazer operação com dois inteiros pensa que o resultado tbm seja iteiro
            double resultado2 = (double) e / f;

            Console.WriteLine(resultado);
            Console.WriteLine(resultado2);

        }
    }
}
