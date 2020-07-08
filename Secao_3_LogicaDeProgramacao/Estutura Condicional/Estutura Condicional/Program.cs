using System;

namespace Estutura_Condicional
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            int x = 10;


            Console.WriteLine("Bom dia!");
            if (x < 5)
            {
                Console.WriteLine("Boa tarde!");
            }
            
            Console.WriteLine("Boa noite!");
            */

            Console.WriteLine("Entre com um numero inteiro");
            int x = int.Parse(Console.ReadLine());

            if ( x % 2 == 0)
            {
                Console.WriteLine("Par!");
            }
            else if (x % 2 != 0)
            {
                Console.WriteLine("Impar!");
            }
        }
    }
}
