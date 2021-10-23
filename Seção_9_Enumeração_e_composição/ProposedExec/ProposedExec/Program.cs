using System;
using ProposedExec.Entities;
using ProposedExec.Entities.Enum;

namespace ProposedExec
{
    class Program
    {
        static void Main(string[] args)
        {
            // Entrar com o cliente 
            Client client = new Client("Hugo", "hugortorquato@gmail.com", DateTime.Parse("16/01/1997"));

            // Definir uma ordem
            Order order = new Order(DateTime.Now, OrderStatus.PROCESSING, client);

            Console.WriteLine(" How mane items to this order ? ");
            int num_itens = int.Parse(Console.ReadLine());
            
            for (int i = 0; i <num_itens; i++)
            {
                Console.WriteLine("Enter #{0} item data :",i);
                Console.WriteLine("Product Name :");
                string product_name = Console.ReadLine();
                Console.WriteLine("Product Price");
                double price = double.Parse(Console.ReadLine());

                Product product = new Product(product_name, price);

                Console.WriteLine("Quantity :");
                int quant = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(quant, price, product);

                order.AddItem(orderItem);
            }

            Console.WriteLine();
            Console.WriteLine("Order Summary:");
            Console.WriteLine(order);
        }
    }
}
