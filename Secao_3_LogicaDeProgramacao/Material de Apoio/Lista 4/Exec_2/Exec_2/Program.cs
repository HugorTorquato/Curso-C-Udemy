using System;

namespace Exec_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Digite quantos valores entrar : ");
            int x = int.Parse(Console.ReadLine());

            int validos = 0;

            for (int i = 0; i < x; i++)
            {
                Console.WriteLine(" ");
                Console.WriteLine(" Digite um valor inteiro ");
                int a = int.Parse(Console.ReadLine());
                if (a >= 10 && a <= 20) validos++;
            }

            Console.WriteLine(" in " + validos);
            int outt = x - validos;
            Console.WriteLine(" outt " + outt);
        }
    }
}
