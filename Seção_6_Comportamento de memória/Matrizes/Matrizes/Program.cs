using System;

namespace Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double[,] mat = new double[2, 3]; // instancia na memoria uma matriz de 2 linhas e 3 colunas 

            Console.WriteLine(mat.Length); // Tamanho da matriz
            Console.WriteLine(mat.Rank); //Tamanho da primeira dimenção da matriz - quantidade de linhas -> usado para percorrer matriz
            Console.WriteLine(mat.GetLength(0)); // A dimenção 0 da matriz tem tamanho 2 -> quantidade de linhas
            Console.WriteLine(mat.GetLength(1)); // A dimenção 1 da matriz tem tamanho 2 -> quantidade de colunas
        }
    }
}
