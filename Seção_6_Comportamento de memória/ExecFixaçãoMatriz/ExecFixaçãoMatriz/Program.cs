using System;

namespace ExecFixaçãoMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Ler números inteiros M,N
             * 
             * Ler uma matriz de M linhas e N colunas
             * 
             * Ler númeoro inteiro X e mostrar valores
             *  -> Esquerda
             *  -> acima
             *  -> direita
             *  -> Baixo
             *  
             *  -> Quando hoouver
             *  
             */


            Console.Write("Entre com a ordem da matriz : ( M N ) ");
            string[] ordem = Console.ReadLine().Split(' ');
            int M = int.Parse(ordem[0]);
            int N = int.Parse(ordem[1]);

            int[,] mat = new int[M, N]; // Instanciação da matriz

            Console.WriteLine(mat.Length);

            for (int i = 0; i < M; i++)
            {

                Console.WriteLine(" Digite a primeira linha da matriz ");
                string[] vet_String = Console.ReadLine().Split(' ');

                for (int j = 0; j < N; j++)
                {
                    mat[i, j] = int.Parse(vet_String[j]);

                }


            }
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine();

            Console.Write(" Entre com o número a ser encontrado : ");
            int X = int.Parse(Console.ReadLine());
            Console.WriteLine();


            /* 0 1 2  3
             * 4 5 6  7
             * 8 9 10 11
             */

            Console.WriteLine();

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (mat[i, j] == X)
                    {
                        if ((j - 1) >= 0) // Esquerda
                        {
                            Console.WriteLine(" Left : " + mat[i, j - 1]);
                        }
                        if ((i - 1) >= 0) // Acima
                        {
                            Console.WriteLine(" UP : " + mat[i - 1, j]);
                        }
                        if ((j + 1) < N) // Direita
                        {
                            Console.WriteLine(" Right : " + mat[i, j + 1]);
                        }
                        if ((i + 1) < M) // Embaixo
                        {
                            Console.WriteLine(" Down : " + mat[i + 1, j]);
                        }
                    }
                    Console.WriteLine();
                }
            }

        }
    }
}