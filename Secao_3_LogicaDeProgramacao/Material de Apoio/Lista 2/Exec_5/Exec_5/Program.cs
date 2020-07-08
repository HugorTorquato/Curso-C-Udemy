using System;

namespace Exec_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o código e a quantidade do item");
            string[] vet = Console.ReadLine().Split(' ');
            int n1 = int.Parse(vet[0]);
            int n2 = int.Parse(vet[1]);

            if (n1 == 1)
            {
                float preco = 4.00f;
                float custo = n2 * (float)preco;
                Console.WriteLine(custo);
            }else if (n1 == 2)
            {
                float preco = 4.50f;
                float custo = n2 * (float)preco;
                Console.WriteLine(custo);
            }
            else if (n1 == 3)
            {
                float preco = 5.00f;
                float custo = n2 * (float)preco;
                Console.WriteLine(custo);
            }
            else if (n1 == 4)
            {
                float preco = 2.00f;
                float custo = n2 * (float)preco;
                Console.WriteLine(custo);
            }
            else if (n1 == 5)
            {
                float preco = 1.50f;
                float custo = n2 * (float)preco;
                Console.WriteLine(custo);
            }

        }
    }
}
