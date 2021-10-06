using System;
using Enumerados1.Entities;
using Enumerados1.Entities.Enums;

namespace Enumerados1
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                // No caso depois de importar o enumerado "enums", o compilador já indica os valores que podem
                // ser escolhidos
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            // Conversão de stringpara enumeração

                // enum -> string
            string txt = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(txt);

                // string -> enum ( o string tem de estar certinho para não dar erro - tem de estar definido no enum)
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine(os);
        }
    }
}
