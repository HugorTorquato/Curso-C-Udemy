using System;
using System.Globalization;

namespace Exec_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o salário");
            float salario = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salario > 0 && salario < 2000.00)
            {
                Console.WriteLine("Isento");
            }
            else if (salario > 0 && salario < 3000.00)
            {
                float imposto = (salario - 2000) * 0.08f;
                Console.WriteLine(imposto);
            }
            else if (salario > 0 && salario < 4500.00)
            {
                float imposto = ((3000 - 2000) * 0.08f) + ((salario - 3000) * 0.18f);
                Console.WriteLine(imposto);
            }
            else
            {
                float imposto = ((3000 - 2000) * 0.08f) + ((4500 - 3000) * 0.18f) + ((salario - 4500) * 0.28f);
                Console.WriteLine(imposto);
            }


        }
    }
}
