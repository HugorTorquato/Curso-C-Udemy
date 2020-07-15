using System;

namespace ExecVetores
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
             * -> 10 quartos para alugar 0~9
             * 
             * -> Inicia os quartos vazios 
             * -> Ler quantidade N de estudantes que vão ocupar os quartos ( N = 1~10 )
             * 
             * -> Registrar o nome e email dos estudantes e qual dos quartos ele escolheu (0~9)
             * -> Suponha que seja escolhido um quarto vago -> não preocupar em verificar se o quarto já está ocupado
             * -> Imprimir um relatório de ocupação do pensionato
             */

            Console.WriteLine("Quantos estudantes vão entrar?");
            int n = int.Parse(Console.ReadLine());

            Estudante[] vect = new Estudante[10]; // instanciação do vetor classes

            for (int x = 0; x < n; x++)
            {
                Console.Write(" Qual seu nome  : ");
                string nome = Console.ReadLine();
                Console.Write(" Qual seu email : ");
                string emai = Console.ReadLine();
                Console.Write(" Qual quarto    : ");
                int quarto = int.Parse(Console.ReadLine());
                Console.WriteLine();

                vect[quarto - 1] = new Estudante { Name = nome, Email = emai, Quarto = quarto }; // intanciação do objeto classe do vetor

            }


            // Relatório

            Console.WriteLine("-----------------Relatório----------------");
            for (int x = 0; x < 10; x++)
            {
                if (vect[x] != null)
                {
                    Console.Write(" Nome do Estudante : " + vect[x].Name);
                    Console.WriteLine(" " + x);
                    //Console.Write(" Nome do Estudante : " + vect[x].Email);
                    //Console.WriteLine("");
                    //Console.Write(" Nome do Estudante : " + vect[x].Quarto);
                    //Console.WriteLine("");
                    Console.WriteLine("");
                }else
                {
                    Console.WriteLine(" VAZIO ");
                }



            }


        }
    }
}
