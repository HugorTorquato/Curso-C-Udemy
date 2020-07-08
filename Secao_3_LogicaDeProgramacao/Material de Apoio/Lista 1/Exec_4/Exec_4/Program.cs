using System;

namespace Exec_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a matricula");
            int mat = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite as horas trabalhadas");
            int horas = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor que recebe por hora");
            double valor = double.Parse(Console.ReadLine());


            double receber = horas * (double)valor;

            Console.WriteLine($"Number: {mat}");
            Console.WriteLine($"Salary: R${receber}");
        }
    }
}
