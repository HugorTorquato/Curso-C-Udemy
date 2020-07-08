using System;

namespace Exec_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int senha_correta = 2002;

            Console.WriteLine("Digite a senha");
            int senha = int.Parse(Console.ReadLine());

            while (senha != senha_correta)
            {
                Console.WriteLine(" Senha Invalida");

                Console.WriteLine("Digite a senha");
                senha = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(" Acesso Permitido" );
        }
    }
}
