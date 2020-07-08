using System;
using System.Globalization;

namespace eXEC_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite os dados da seguite forma para a peça 1:");
            Console.WriteLine("(Código (um. Pelas) (Valor Unitário):");
            string[] vet1 = Console.ReadLine().Split(' ');
            int codigo1 = int.Parse(vet1[0]);
            int num_pecas1 = int.Parse(vet1[1]);
            double valor1 = double.Parse(vet1[2], CultureInfo.InvariantCulture);

            Console.WriteLine("Digite os dados da seguite forma para a peça 2:");
            Console.WriteLine("(Código (um. Pelas) (Valor Unitário):");
            string[] vet2 = Console.ReadLine().Split(' ');
            int codigo2 = int.Parse(vet2[0]);
            int num_pecas2 = int.Parse(vet2[1]);
            double valor2 = double.Parse(vet2[2], CultureInfo.InvariantCulture);

            double valor = (num_pecas1 * valor1) + (num_pecas2 * valor2);

            Console.WriteLine("´VALOR A PAGAR: " + valor.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
