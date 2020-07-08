using System;

namespace Exec_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro positivo");
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                int n1 = i;
                int n2 = (int)Math.Pow(i, 2);
                int n3 = (int)Math.Pow(i, 3); ;

                Console.WriteLine(n1 + " " + n2 + " " + n3);


            }
        }
    }
}
