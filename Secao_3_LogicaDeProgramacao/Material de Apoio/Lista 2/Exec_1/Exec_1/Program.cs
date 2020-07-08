using System;

namespace Exec_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro");
            int x = int.Parse(Console.ReadLine());

            if (x > 0) Console.WriteLine("Positivo");
            else Console.WriteLine("Negativo");
               
        }
    }
}
