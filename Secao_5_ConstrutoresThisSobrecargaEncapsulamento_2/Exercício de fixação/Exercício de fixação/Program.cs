using System;

namespace Exercício_de_fixação
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o nome do titular da conta?");
            string nome = Console.ReadLine();
            Console.WriteLine(" Qual o valor do deposito inicial?");
            double cond = double.Parse(Console.ReadLine());

            Cliente c = new Cliente(nome, cond);

            Console.WriteLine(c);

            Console.WriteLine("Qual o valor do deposito que deseja fazer?");
            double dep = double.Parse(Console.ReadLine());

            c.Deposito(dep);

            Console.WriteLine("Qual o valor do saque que deseja fazer?");
            double saq = double.Parse(Console.ReadLine());

            c.Saque(saq);

            Console.WriteLine(c.NomeTitular);
            //Console.WriteLine(c._nomeTitular);
            Console.WriteLine(c.Saldo);
            //Console.WriteLine(c._saldo);

        }
    }
}
