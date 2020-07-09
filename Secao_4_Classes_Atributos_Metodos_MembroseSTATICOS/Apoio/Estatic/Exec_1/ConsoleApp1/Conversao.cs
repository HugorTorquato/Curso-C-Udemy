using System;


namespace ConsoleApp1
{
    class Conversao
    {
        public static double Cotacao;
        public static double Comprar;
        public static double IOF = 0.06;

        public static double ValorPago()
        {
            return (Comprar * Cotacao) * (1 + IOF);
        }
    }
}
