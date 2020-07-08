using System;
using System.Globalization;

namespace Exec_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite dois valores com uma casa decimal");
            string[] vet = Console.ReadLine().Split(' ');
            float x = float.Parse(vet[0], CultureInfo.InvariantCulture);
            float y = float.Parse(vet[1], CultureInfo.InvariantCulture);

            if (x == 0 && y == 0) Console.WriteLine( " Origem " );
            else if ( x == 0 ) Console.WriteLine(" Eixo X ");
            else if (y == 0) Console.WriteLine(" Eixo Y ");
            else if ( x > 0)
            {
                if ( y > 0) Console.WriteLine(" Q1 ");
                else Console.WriteLine(" Q4 ");
            }
            else if (x < 0)
            {
                if (y > 0) Console.WriteLine(" Q2 ");
                else Console.WriteLine(" Q3 ");
            }

        }
    }
}
