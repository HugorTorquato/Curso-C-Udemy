using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args) // Função padrão do programa, ponto de entrada
        {
            Console.WriteLine("Digite 3 números");

            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            /*
            if (n1 > n2 && n1 > n3)
            {
                Console.WriteLine("Maior = " + n1);
            }
            else if (n2 > n3)
            {
                Console.WriteLine("Maior = " + n2);
            }
            else
            {
                Console.WriteLine("Maior = " + n3);
            }
            */
            double resultado = Maior(n1, n2, n3);
            Console.WriteLine(" Resultado função " + resultado);
        }

        static int Maior(int a, int b, int c)    // Saida do tipo inteiro
        {
            int m;
            if (a > b && a > c)
            {
                m = a;
            }
            else if (b > c)
            {
                m = b;
            }
            else
            {
                m = c;
            }
            return m;

        }
    }
}
