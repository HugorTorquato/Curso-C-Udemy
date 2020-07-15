using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace VetorTipoClasse
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Product[] vect = new Product[n]; // Instancia o VETOR de classes



            // Instanciar os Objetos
            for (int x = 0; x < n; x++)
            {
                Console.WriteLine("Digite o nome do produto");
                string nome = Console.ReadLine();
                Console.WriteLine("Digite o preço do Produto");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                vect[x] = new Product { Name = nome, Price = preco }; // instancia os objetos classes

            }


            double soma = 0.0;
            for (int x=0; x < n; x++)
            {
                soma += vect[x].Price;
            }

            double avg = soma / n;

            Console.WriteLine(" Preço médio igual a : " + avg.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
