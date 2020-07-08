using System;

namespace Exec_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a hora inicial e final do jogo");
            string[] vet = Console.ReadLine().Split(' ');
            int init = int.Parse(vet[0]);
            int end = int.Parse(vet[1]);

            if (init == end) Console.WriteLine(" O jogo durou 24 horas");
            else if ( init < end)
            {
                int Tempo = end - init;
                Console.WriteLine($" O joge durou {Tempo} horas");
            }
            else
            {
                int Tempo1 = 24 - init;
                int Tempo2 = Tempo1 + end;
                Console.WriteLine($" O joge durou {Tempo2} horas");
            }
        }
    }
}
