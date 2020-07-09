using System;

namespace Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            // double x = null; // Erro pq o x é um valor não nulo

            //Nullable<double> x = null; // Não da mais erro

            // Forma mais simples
            double? x = null;

            double? y = 10.0;


            Console.WriteLine(x.GetValueOrDefault()); // Imprime zero 
            Console.WriteLine(y.GetValueOrDefault()); // IMprime o valor 

            Console.WriteLine(x.HasValue); // Fala que não tem valor (false)
            Console.WriteLine(y.HasValue); // Fala que tem valor     (true)

            //Console.WriteLine(x.Value); // Quebra a aplicação
            Console.WriteLine(y.Value); // Pega o valor

            //  Operador de coalescência Nula (??)

            double? q = x ?? 5;
            double? a = y ?? 5;

            Console.WriteLine(q);
            Console.WriteLine(a);



        }
    }
}
