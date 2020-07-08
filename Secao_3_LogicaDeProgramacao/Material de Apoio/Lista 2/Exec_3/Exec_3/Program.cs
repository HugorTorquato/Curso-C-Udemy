using System;
using System.Numerics;

namespace Exec_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 0;
            int x2 = 0;

            Console.WriteLine("Digite dois valores inteiros");
            string[] vet = Console.ReadLine().Split(' ');
            int n1 = int.Parse(vet[0]);
            int n2 = int.Parse(vet[1]);

            if (n1 > n2)
            {
                x1 = n1;
                x2 = n2;
            } else
            {
                x1 = n2;
                x2 = n1;
            }

            if (x1 % x2 == 0) Console.WriteLine(" São Multiplos");
            else Console.WriteLine("Não são multiplos");
        }
    }
}
