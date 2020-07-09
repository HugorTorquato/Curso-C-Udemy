using System;
using System.Globalization;
using System.IO.Pipes;

namespace Membros_Estáticos
{
    class Program
    {
        
        static void Main(string[] args)
        {
            /* Ler um valor numerico qualquer e 
             * mostrar quanto seria o valor de 
             * uma circunferência e do volume de 
             * uma esfera para um raio de qualquer
             * valor. Informar também o valor de 
             * PI com duas casas decimais
             */


            // 1- Metodos na propria classe do programa
            /*
            Console.Write("Entre o valor do raio : ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            double circ = Circunf(raio);

            Console.WriteLine(" Circunferencia : " + circ.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine(" Volume : " + Vol(raio).ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine(" PI : " + pi.ToString("F2", CultureInfo.InvariantCulture));

            */

            // 2- Orientado objeto
            /*
            Calculadora Calc = new Calculadora();

            Console.Write("Entre o valor do raio : ");
            Calc.Raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(" Circunferencia : " + Calc.Circunf().ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine(" Volume : " + Calc.Vol().ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine(" PI : " + Calc.pi.ToString("F2", CultureInfo.InvariantCulture));
            */

            //3- Membros estáticos
            // -> São calculos estáticos

            //Calculadora Calc = new Calculadora(); // Não tem de instanciar

            Console.Write("Entre o valor do raio : ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(" Circunferencia : " + CalculadoraEstatic.Circunferencia(raio).ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine(" Volume : " + CalculadoraEstatic.Vol(raio).ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine(" PI : " + CalculadoraEstatic.pi.ToString("F2", CultureInfo.InvariantCulture));



        }
        /*
        static double Circunf(double r)
        {
            return 2.00 * pi * r;
        }

        static double Vol(double r)
        {
            return (4/3)* pi * Math.Pow(r, 3);            
        }
        */
    }
}
