using System;

namespace Exec_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o tipo de combustivel utilizado");
            Console.WriteLine(" 1- Alcool ");
            Console.WriteLine(" 2- Gasolina ");
            Console.WriteLine(" 3- Diesel ");
            Console.WriteLine(" 4- Fim");

            int num = int.Parse(Console.ReadLine());

            int num_1 = 0;
            int num_2 = 0;
            int num_3 = 0;

            while (num != 4)
            {
                while (num < 1 && num > 4)
                {
                    Console.WriteLine("Código invalido, tente novamente");
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine("Digite o tipo de combustivel utilizado");
                    Console.WriteLine(" 1- Alcool ");
                    Console.WriteLine(" 2- Gasolina ");
                    Console.WriteLine(" 3- Diesel ");
                    Console.WriteLine(" 4- Fim");

                    num = int.Parse(Console.ReadLine());
                }

                if (num == 1) num_1 = (int)num_1++;
                else if (num == 2) num_2 = (int)num_2++;
                else if (num == 2) num_2 = (int)num_2++;

                Console.WriteLine("Digite o tipo de combustivel utilizado");
                Console.WriteLine(" 1- Alcool ");
                Console.WriteLine(" 2- Gasolina ");
                Console.WriteLine(" 3- Diesel ");
                Console.WriteLine(" 4- Fim");
                num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(" MUITO OBRIGADO ");
            Console.WriteLine(" 1- Alcool " + num_1);
            Console.WriteLine(" 2- Gasolina " + num_2);
            Console.WriteLine(" 3- Diesel " + num_3);
        }
    }
}
