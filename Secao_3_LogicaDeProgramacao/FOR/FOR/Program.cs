using System;

namespace FOR
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * inicio -> Execulta somente uma vez
             * condição -> determina se fica ou não no lop
             * incremento -> em todo loop execulta isso
             * 
             * Syntaxe
             * for ( inicio ; condição ; incremento){
             *  comando 1
             *  comando 2
             *}
             */
            Console.WriteLine("Quantos números inteiros vai digitar?");
            int vezes = int.Parse(Console.ReadLine());

            int soma = 0;
            for ( int i = 1; i <= vezes; i++)
            {
                Console.WriteLine("Valor : #{0}:", i);
                int valor = int.Parse(Console.ReadLine());
                //soma = soma + valor;
                soma += valor;
            }
            Console.WriteLine("Soma = " + soma);




        }
    }
}
