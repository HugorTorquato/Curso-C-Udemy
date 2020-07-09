using System;
using System.Globalization;

namespace Exec_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno Aluno1 = new Aluno();

            Console.Write("Nome do Aluno : ");
            Aluno1.Nome = Console.ReadLine();

            Console.WriteLine(" Digite as três notas do aluno");
            Aluno1.N1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Aluno1.N2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Aluno1.N3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(" Nota Final = " + Aluno1.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));
            if (Aluno1.NotaFinal() < 60)
            {
                Console.WriteLine(" Reprovado ");
                Console.WriteLine(" Faltam " + Aluno1.Restante().ToString("F2", CultureInfo.InvariantCulture) + " Pontos");
            }
            else Console.WriteLine(" Aprovado");


        }
    }
}
