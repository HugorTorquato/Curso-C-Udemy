using System;
using System.Globalization;

namespace Exec_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario Func = new Funcionario();

            Console.Write("Digite seu nome : ");
            Func.Nome = Console.ReadLine();
            Console.Write("Digite seu Salario bruto : ");
            Func.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite o Imposto : ");
            Func.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine(" Nome : " + Func.Nome);
            Console.WriteLine(" Salário Bruto : " + Func.SalarioBruto.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(" Imposto : " + Func.Imposto.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine();
            Console.WriteLine(" Funcionário : " + Func.Nome + ", $ " + Func.Salario());

            Console.Write("Digite o Aumento Recebido : ");
            Func.Aumento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Func.Raise();

            Console.WriteLine();
            Console.WriteLine(" Dados Atualizados : " + Func.Nome + ", $ " + Func.Salario());

        }
    }
}
