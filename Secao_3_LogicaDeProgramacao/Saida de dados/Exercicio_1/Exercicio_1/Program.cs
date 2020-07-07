using System;
using System.Globalization;

namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto1 = " Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double precoo2 = 650.0;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1}, cujo preço é $ {preco1}");
            Console.WriteLine($"{produto2}, cujo preço é $ {precoo2}");
            Console.WriteLine(" ");
            Console.WriteLine($"rEGISTRO: {idade} anos de idade, código {codigo} e gÊnero: {genero}");
            Console.WriteLine(" ");
            Console.WriteLine($"Medida com oito casas decimais: {medida:F8}");
            Console.WriteLine($"Arredondando (Três casas decimais): {medida:F3}");
            Console.WriteLine("Separador decimal invariant culture: {0}", medida.ToString("F3",CultureInfo.InvariantCulture));


        }
    }
}
