using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ModificadorDeParametrosParams
{
    class Calculator
    {
        // Função soma com 3 sobrecargas
        /*
        public static int Sum(int n1, int n2)
        {
            return n1 + n2;
        }
        public static int Sum(int n1, int n2, int n3)
        {
            return n1 + n2 + n3;
        }
        public static int Sum(int n1, int n2, int n3, int n4)
        {
            return n1 + n2+ n3 + n4;
        }
        */

        public static int Sum(int[] numbers) // função que recebe o vetor
        {
            int sum = 0;
            for (int x =0; x<numbers.Length; x++)
            {
                sum += numbers[x];
            }
            return sum;
        }

        public static int Sum2(params int[] numbers) // params + declaração da entrada como vetor
        {
            int sum = 0;
            for (int x = 0; x < numbers.Length; x++)
            {
                sum += numbers[x];
            }
            return sum;
        }

    }
}
