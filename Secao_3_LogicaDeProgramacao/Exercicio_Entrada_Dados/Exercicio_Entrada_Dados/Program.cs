using System;
using System.Globalization;

namespace Exercicio_Entrada_Dados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome ocmpleto");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem sua casa?");
            int _num_quartos = int.Parse(Console.ReadLine());
            Console.WriteLine(" Entre com o preço do produto:");
            double preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine(" eNTRE SEU ÚLTIMO NOME, IDADE E ALTURA ( MESMA LINHA) ");
            string[] vet = Console.ReadLine().Split(' ');
            string _ultimo_nome = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine(nome);
            Console.WriteLine(_num_quartos);
            Console.WriteLine(preco);
            Console.WriteLine(_ultimo_nome);
            Console.WriteLine(idade);
            Console.WriteLine(altura);

            
        }
    }
}
