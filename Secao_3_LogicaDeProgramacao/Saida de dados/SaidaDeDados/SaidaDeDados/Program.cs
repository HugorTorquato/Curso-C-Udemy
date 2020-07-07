using System;
using System.Globalization;

namespace SaidaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bom dia");
            Console.WriteLine("Boa tarde");
            Console.WriteLine("Boa noite");

            // Imprimir variáveis 

            char genero = 'F';
            int idade = 32;
            double saldo = 10.3584;
            string nome = " Hugo";

            Console.WriteLine("-------------");
            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo);
            Console.WriteLine(saldo.ToString("F3")); // lIMITA O NUMERO DE CASAS 
            Console.WriteLine(saldo.ToString("F2")); // lIMITA O NUMERO DE CASAS 
            Console.WriteLine(nome);
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture)); //Desconsidera qualquer formatação especifica de país ( no caso troca a virdula por ponto )


            Console.WriteLine("-------------------");
            //PlaceHolders
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo);
            //Interpolação 
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais");
            //Concatenação de strings
            Console.WriteLine(nome + " tem " + idade + " anos e tem salfo igual a " + saldo.ToString("f2", CultureInfo.InvariantCulture) + " reais");

        }
    }
}
