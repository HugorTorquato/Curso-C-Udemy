using System;

namespace Escopo_e_inicialização
{
    class Program
    {
        static void Main(string[] args)
        {
            // Não pode fazer, tem de inicializar a variavel de alguma forma
            /*
            int x;

            Console.WriteLine(x);
            */

            double preco = double.Parse(Console.ReadLine());
            double desconto = 0;

            if ( preco > 100.0)
            {
                double descontro = preco * 0.1;
            }

            // Não pode imprimir a variável desconto pq foi declaradadentro da estrutura if- Pertence ao escopo do if, e não do principal
            // Se for declarada antes, como está agora, pode ser impressa

            Console.WriteLine(desconto);


        }
    }
}
