using System;

namespace EXEC_VET
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num_quartos = 10;

            Quarto[] vect = new Quarto[Num_quartos];

            Console.WriteLine("Quantos quartos deseja alugar?");
            int Quant = int.Parse(Console.ReadLine());

            //for (int j = 0; j < Num_quartos; j++) { vect[j] = new Quarto(j); }

            for (int i = 0; i < Quant; i++)
            {
                Console.WriteLine(" Qual quarto deseja alugar?:");
                int NQuarto = int.Parse(Console.ReadLine());
                Console.WriteLine(" Qual o seu nome?");
                //vect[NQuarto].Nome = Console.ReadLine();
                string nome = Console.ReadLine();
                Console.WriteLine(" Qual o seu email?");
                //vect[NQuarto].Email = Console.ReadLine();
                string email = Console.ReadLine();

                vect[NQuarto - 1] = new Quarto(nome, email, NQuarto);

            }

            for (int j = 0; j < Num_quartos; j++)
            {
                if (vect[j] != null)
                {
                    Console.WriteLine(vect[j]);
                }

            }


        }
    }
}
