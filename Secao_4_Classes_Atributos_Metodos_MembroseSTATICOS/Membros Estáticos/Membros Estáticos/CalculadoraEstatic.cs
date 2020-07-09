using System;

namespace Membros_Estáticos
{
    class CalculadoraEstatic
    {
        public static double pi = 3.14;
        //public static double Raio;

        public static double Circunferencia(double Raio)
        {
            return 2.00 * pi * Raio;
        }

        public static double Vol(double Raio)
        {
            return (4 / 3) * pi * Math.Pow(Raio, 3);
        }
    }
}
