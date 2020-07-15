using System;

namespace ModificadorDeParametrosRefEOut
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            //Calculator.Triple(a); -> Passando valor, por isso não está funcionando
            Calculator.Triple(ref a); // -> O patametro X se torna uma referência para a variável original, vai alterar a original
            Console.WriteLine(a);

            Calculator.Triple2(ref a, out int b); // OUT -> parametro de saida passado por ref
            Console.WriteLine();
            Console.WriteLine(b);

        }
    }
}
