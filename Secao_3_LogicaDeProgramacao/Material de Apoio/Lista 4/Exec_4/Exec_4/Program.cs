using System;

namespace Exec_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite quantas repetições : ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < x; i++)
            {
                Console.WriteLine(" ");
                Console.WriteLine(" Digite os pares de números para a divisão ");
                string[] numrs = Console.ReadLine().Split(' ');
                int n1 = int.Parse(numrs[0]);
                int n2 = int.Parse(numrs[1]);

                if (n2 == 0) Console.WriteLine("Divisão Impossível");
                else
                {
                    double Divisao = (double)n1 / n2;
                    Console.WriteLine(Divisao);
                }

            }
        }
    }
}
