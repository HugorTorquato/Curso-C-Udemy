using System;

namespace Exec_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro");
            int x = int.Parse(Console.ReadLine());

            if (x % 2 == 0) Console.WriteLine(" Par");
            else Console.WriteLine("Impar");
        }
    }
}
