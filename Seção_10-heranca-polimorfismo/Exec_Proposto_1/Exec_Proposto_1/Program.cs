using System;
using Exec_Proposto_1.Entities;
using System.Globalization;
using System.Collections.Generic;

namespace Exec_Proposto_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> li = new List<Product>();

            Console.Write(" Enter the number of products: ");
            int num = int.Parse(Console.ReadLine());


            for (int i = 0; i < num; i++)
            {
                Console.Write("Common, Used or Imported (c,u,i):");
                char mode = char.Parse(Console.ReadLine());

                Console.Write("Name :");
                string name = Console.ReadLine();
                Console.Write("Price :");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                switch (mode)
                {
                    case 'c':
                        li.Add(new Product(name, price));
                        break;

                    case 'u':
                        Console.Write("Manufacture date (DD/MM/YYYY)");
                        DateTime date = DateTime.Parse(Console.ReadLine());
                        li.Add(new UsedProduct(name, price, date));
                        break;

                    case 'i':
                        Console.Write("Customs fee :");
                        double fee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        li.Add(new ImportedProduct(name, price, fee));
                        break;
                }
            }

            Console.WriteLine("");
            foreach(Product p in li)
            {
                Console.WriteLine(p.priceTag());
            }
        }
    }
}
