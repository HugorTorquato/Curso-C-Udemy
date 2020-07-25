using System;
using System.Diagnostics.Tracing;

namespace ProblemaExemploMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Fazer um programa para ler um número inteiro N e criar uma matriz de ordem N contendo númeors inteiros
             * Mostra a diagonal principal e a quantidade de valores negativos da matriz
             */

            int[] diagonal = new int[3];
            int Negative = 0;

            Console.Write("Entre com a ordem da matriz : ");
            int N = int.Parse(Console.ReadLine());

            int[,] mat = new int[N, N]; // Instanciação da matriz

            Console.WriteLine(mat.Length);

            for (int i = 0; i < N; i++){

                Console.WriteLine(" Digite a primeira linha da matriz ");
                string[] vet_String = Console.ReadLine().Split(' ');

                for (int j = 0; j < N; j++)
                {
                    mat[i, j] = int.Parse(vet_String[j]);
                    diagonal[i] = int.Parse(vet_String[i]);
                    if (int.Parse(vet_String[j]) < 0) { Negative += 1; }
                }


            }

            Console.WriteLine(" Main Diagonal ") ;
            foreach (int valor in diagonal) { Console.Write(valor + " "); }
            Console.WriteLine(" Negative Numbers : " + Negative);

        }
    }
}
