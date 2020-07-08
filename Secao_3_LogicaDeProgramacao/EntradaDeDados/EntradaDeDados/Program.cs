using System;
using System.Dynamic;
using System.Globalization;

namespace EntradaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string frase = Console.ReadLine(); // lé até chegar em uma quebra de linha
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();


            // Comando Split
            //string s = Console.ReadLine();
            //string[] vet = s.Split(' ');
            //string p1 = vet[0], p2 = vet[1], p3 = vet[2];

            string[] vet = Console.ReadLine().Split(' ');
            string p1 = vet[0], p2 = vet[1], p3 = vet[2];

            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);

            */

            int n1 = int.Parse(Console.ReadLine()); // Le os dadso na forma string, tem que fazer a conversão
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // Consegue ler independet de 
                                                                                        // ponto ou virgula para identificar separadores

            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

            Console.WriteLine("VC digitou {0}",n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2);
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura);


        }
    }
}
