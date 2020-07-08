using System;

namespace Exec_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um valor Inteiro : ");
            int valor = int.Parse(Console.ReadLine());

            for (int x = 0; x <= valor; x++)
            {
                if (x % 2 != 0) Console.WriteLine(x);
            }
        }
    }
}
