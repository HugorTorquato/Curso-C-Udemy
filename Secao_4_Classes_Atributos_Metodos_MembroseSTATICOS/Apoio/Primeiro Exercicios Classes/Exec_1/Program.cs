using System;

namespace Primeiro_Exercicios_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa Pes1, Pes2;
            Pes1 = new Pessoa();
            Pes2 = new Pessoa();

            Console.WriteLine("Digite Seu nome");
            Pes1.Nome = Console.ReadLine();
            Console.WriteLine(" Digite sua idade");
            Pes1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite Seu nome");
            Pes2.Nome = Console.ReadLine();
            Console.WriteLine(" Digite sua idade");
            Pes2.Idade = int.Parse(Console.ReadLine());

            if (Pes1.Idade > Pes2.Idade) Console.WriteLine(Pes1.Nome);
            else Console.WriteLine(Pes2.Nome);
        }
    }
}
