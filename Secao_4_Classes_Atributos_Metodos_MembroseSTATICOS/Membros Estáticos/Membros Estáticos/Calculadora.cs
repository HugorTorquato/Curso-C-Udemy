using System;

namespace Membros_Estáticos
{
    class Calculadora
    {
        public double pi = 3.14;
        public double Raio;

        public double Circunf()
        {
            return 2.00 * pi * Raio;
        }

        public double Vol()
        {
            return (4 / 3) * pi * Math.Pow(Raio, 3);
        }
    }
}
