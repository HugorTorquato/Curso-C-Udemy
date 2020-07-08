using System;
using System.Globalization;

namespace Exec_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("insira 3 valores com ponto flutuante de de dupla precisão");
            string[] vet = Console.ReadLine().Split(' ');
            float A = float.Parse(vet[0], CultureInfo.InvariantCulture);
            float B = float.Parse(vet[1], CultureInfo.InvariantCulture);
            float C = float.Parse(vet[2], CultureInfo.InvariantCulture);

            float Letra_A = ((float)A * C) / 2;
            float Letra_B = ((float)Math.PI * (float)Math.Pow(C, 2));
            float Letra_C = (((float)A + B) * C) / 2;
            float Letra_D = (float)Math.Pow(B, 2);
            float Letra_E = (float)A * B;

            Console.WriteLine("TRIANGULO: " + Letra_A.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO:   " + Letra_B.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO:  " + Letra_C.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO:  " + Letra_D.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + Letra_E.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
