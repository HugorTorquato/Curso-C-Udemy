using System;
using System.Collections.Generic;
using System.Text;
using ProposedExec.Entities.Enum;
using System.Globalization;

namespace ProposedExec.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; } // Tem de associar o status do pedido
        public Client Client { get; set; } // e uma ordem tem de estar associada a um cliente
        public List<OrderItem> Items { get; set; } = new List<OrderItem>(); 
        // Um cliente pode fazer mais de um pedido, logo pode receber mais de uma lista

        public Order()
        {

        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem orderitem)
        {
            Items.Add(orderitem);
        }

        public void RemoveItem(OrderItem orderitem)
        {
            Items.Remove(orderitem);
        }
        
        public double Total()
        {
            // Pega o sutotal de cada produtp e joga para dentro da soma
            double sum = 0;

            foreach(OrderItem item in Items)
            {
                sum += item.SubTotal();
            }

            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Order Moment : " + Moment.ToString("dd/MM/yyy HH:mm:ss"));
            sb.AppendLine("Order Status : " + Status);
            sb.AppendLine("Client       : " + Client);

            foreach (OrderItem item in Items)
            {
                sb.AppendLine(item.ToString());
            }

            sb.AppendLine("Total Price : $" + Total().ToString("F2", CultureInfo.InvariantCulture));

            return sb.ToString();
        }
    }
}
