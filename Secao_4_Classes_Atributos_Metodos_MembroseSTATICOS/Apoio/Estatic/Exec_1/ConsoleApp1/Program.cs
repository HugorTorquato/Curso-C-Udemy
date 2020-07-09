using System;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite a cotação do dolar : ");
            Conversao.Cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine(" Quantos dolares vai comprar? ");
            Conversao.Comprar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(" Valor a ser pago em reias = " + Conversao.ValorPago().ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
