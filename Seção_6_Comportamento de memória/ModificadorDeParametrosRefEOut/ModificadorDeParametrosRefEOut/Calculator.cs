using System;
using System.Collections.Generic;
using System.Text;

namespace ModificadorDeParametrosRefEOut
{
    class Calculator
    {
        /*
        public static void Triple(int x)
        {
            x = x * 3;
        }
        */
        public static void Triple(ref int x)
        {
            x = x * 3;
        }

        public static void Triple2(ref int x, out int result) // Passar o valor de origem e guardar o resultado em um valor de saida
        {
            result = x * 3;
        }
    }
}
