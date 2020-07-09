using System;
using System.Globalization;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;

namespace Fixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciação padrão
            //Conta Cont1 = new Conta();
            Conta Cont1;

            // Entrada de dados
            Console.Write(" Entre o número da conta : ");
            int numconta = int.Parse(Console.ReadLine());
            Console.Write(" Entre o titular da conta : ");
            string nomeconta = Console.ReadLine();
            Console.Write(" Haverá depósito inicial (s/n)? ");
            char verif = char.Parse(Console.ReadLine());
            double depoInicial = 0;
            if (verif == 's' || verif == 'S')
            {
                Console.Write(" Entre o valor de depósito inicial : ");
                depoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                // Instanciação depois dos dados
                Cont1 = new Conta(nomeconta, numconta, depoInicial);
            }
            else
            {
                // Instanciação depois dos dados
                Cont1 = new Conta(nomeconta, numconta);
            }
            
            Console.WriteLine(" Dados da conta: ");
            Console.WriteLine(Cont1);
            Console.WriteLine();

            Console.Write(" Entre um valor para depósito : ");
            double Dep = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Cont1.Deposito(Dep);

            Console.WriteLine(" Dados da conta Atualizados: ");
            Console.WriteLine(Cont1);
            Console.WriteLine();


            Console.Write(" Entre um valor para depósito : ");
            double Saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Cont1.Saque(Saque);

            Console.WriteLine(" Dados da conta Atualizados: ");
            Console.WriteLine(Cont1);







        }
    }
}
