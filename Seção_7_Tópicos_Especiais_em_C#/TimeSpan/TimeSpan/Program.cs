using System;

namespace TimeSpanA
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan T1 = new TimeSpan(0, 1, 30);

            Console.WriteLine(T1); // Tempo decorrido do zero até o número
            Console.WriteLine(T1.Ticks); // quantidades de ticks

            TimeSpan t2 = new TimeSpan(); // Construtor zerado
            TimeSpan t3 = new TimeSpan(900000000L); // Construtor com a quantidade de ticks
            TimeSpan t4 = new TimeSpan(0, 1, 30);//Construtor que passa hora minuto segundo
            TimeSpan t5 = new TimeSpan(1, 2, 11, 21); //Construtor com dias( dias//horas/min/seg))
            TimeSpan t6 = new TimeSpan(1, 2, 11, 21, 199);// mesma coisa do anterior com milissegundos agora

            TimeSpan t7 = TimeSpan.FromDays(1.5); // Cria um timespan referente a um dia e meio -> Conversa na udidae que quer usando númeors quebrados





        }
    }
}
