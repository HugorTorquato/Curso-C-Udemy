using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            Console.WriteLine(a);

            a += 2; 
            Console.WriteLine(a);

            a *= 2;
            Console.WriteLine(a);

            // += tbm funciona com string
            string s = "ABC";
            Console.WriteLine(s);

            s += "DE";
            Console.WriteLine(s);

            // Ordem de atribuição

            int b = 10;
            int c = b++;
            int d = ++b;

            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);


        }
    }
}
