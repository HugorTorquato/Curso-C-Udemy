﻿using System;
using System.Globalization;

namespace Sobrecarga
{
    class Program
    {
        static void Main(string[] args)
        {
            //Construtor com argumentos
            //Produto p = new Produto("TV", 500, 10);
            //Console.WriteLine(p);

            // Linguagem Alternativa
            // -> Funciona mesmo que sem construtores implementados
            /* Produto p = new Produto() {
             *  Nome = "TV",
             *  Preco = 00.0,
             *  Quantidade = 0
             *  };
             */

            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Produto p = new Produto(nome, preco);

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

        }
    }
}