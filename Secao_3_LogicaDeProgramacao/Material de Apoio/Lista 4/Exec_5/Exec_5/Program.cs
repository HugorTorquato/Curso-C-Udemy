using System;

namespace Exec_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o numero : ");
            int N = int.Parse(Console.ReadLine());

            double result = 1;
            for (int i = 0; i < N; i++)
            {
                result = result * (N - i);
            }
            Console.WriteLine(result);
        }
    }
}
