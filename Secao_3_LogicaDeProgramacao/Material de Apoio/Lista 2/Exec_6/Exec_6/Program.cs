using System;
using System.Globalization;

namespace Exec_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor qualquer");
            float x = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (x >=0 && x < 25) Console.WriteLine(" 0-25 ");
            else if (x >= 0 && x < 50) Console.WriteLine(" 25-50 ");
            else if (x >= 0 && x < 75) Console.WriteLine(" 50-75 ");
            else if (x >= 0 && x < 100) Console.WriteLine(" 75-100 ");
            else Console.WriteLine("Fora do Intervalo");
        }
    }
}
