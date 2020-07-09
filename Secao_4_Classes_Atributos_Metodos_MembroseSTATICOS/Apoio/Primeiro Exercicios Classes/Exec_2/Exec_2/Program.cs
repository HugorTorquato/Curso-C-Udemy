using System;
using System.Globalization;

namespace Exec_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario Func1, Func2;
            Func1 = new Funcionario();
            Func2 = new Funcionario();


            Console.WriteLine("Digite Seu nome");
            Func1.Nome = Console.ReadLine();
            Console.WriteLine("Digite Seu salário");
            Func1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite Seu nome");
            Func2.Nome = Console.ReadLine();
            Console.WriteLine("Digite Seu salário");
            Func2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double Media = (Func1.Salario + Func2.Salario) / 2.0;
            Console.WriteLine(" Média dos salários é : " + Media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
