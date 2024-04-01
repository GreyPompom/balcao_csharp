using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using balcao.Entities.Enums;
using System.Globalization;


namespace balcao.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Cliente Cliente { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        


        public Order() { }

        public Order(DateTime moment, OrderStatus status, Cliente cliente)
        {
                Moment = moment;
                Status = status;
                Cliente = cliente;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double soma = 0.0;
            foreach( OrderItem item in Items)
            {
                soma += item.SubTotal();
            }
           
            return soma;
        }

        public override string ToString()
        {
            StringBuilder constroiString = new StringBuilder();
            constroiString.AppendLine("Order moment: "+Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            constroiString.AppendLine("Order status: "+Status);
            constroiString.AppendLine("Client: "+Cliente);
            constroiString.AppendLine("Order itens: ");
            foreach (OrderItem item in Items)
            {
                constroiString.AppendLine(item.ToString());
            }
                constroiString.AppendLine("Total Price: $"+ Total().ToString("F2", CultureInfo.InvariantCulture));

            return constroiString.ToString();
        }

    }
}
