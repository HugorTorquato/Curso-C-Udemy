using System;
using System.Globalization;

namespace Segundo_Projeto_Exemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Programa para ler os dados de um produto no estoque
             * -> nome
             * ->preço
             * ->quantidade
             * 
             * Tem de fazer
             * -> Mostrar os dados do produto
             * -> Realizar uma entrada no estoque e mostrar os dados do produto
             * -> Realizar uma saída no estoque e mostrar novamente os dados do produto
             * 
             */

            Produto p = new Produto();


            Console.WriteLine("Entre os dados do produto : ");
            Console.Write(" Nome : ");
            p.Nome = Console.ReadLine();
            Console.Write(" Preço : ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write(" Quantidade no estoque : ");
            p.Quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine(" Dados do produto: " + p);

            Console.WriteLine();
            Console.Write(" Digite o número de produtos a ser adicionado: ");
            int qte = int.Parse(Console.ReadLine());

            p.AdicionarProdutos(qte);
            Console.WriteLine();
            Console.WriteLine(" Dados do produto: " + p);

            Console.WriteLine();
            Console.Write(" Digite o número de produtos a ser removidos: ");
            qte = int.Parse(Console.ReadLine());

            p.RemoverProdutos(qte);
            Console.WriteLine();
            Console.WriteLine(" Dados do produto: " + p);



        }
    }
}
