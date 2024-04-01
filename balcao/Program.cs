using System;
using balcao.Entities.Enums;
using balcao.Entities;
namespace balcao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( "Enter Cliente Data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write( "Email: " );
            string email = Console.ReadLine();
            Console.Write("birth Date DD/MM/YYYY: ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

           Cliente cliente = new Cliente(name, email, birthDate);

            Console.WriteLine("Enter Order DATA: ");
            Console.Write("Status: ");
            OrderStatus status  = Enum.Parse<OrderStatus>(Console.ReadLine());

            Order pedido = new Order(DateTime.Now, status, cliente);
            
            Console.Write("How many items to this order? ");
            int i = int.Parse( Console.ReadLine());
            for (int j = 0; j < i; j++) {
                Console.WriteLine("Enter #"+j+" item data:");

                Console.Write("Product Name: ");
                string nome = Console.ReadLine();
                Console.Write("Product Price: ");
                double price = int.Parse(Console.ReadLine());
                Product product = new Product(name, price);
                Console.Write("Quantity: ");

                int quant = int.Parse(Console.ReadLine());
                OrderItem item = new OrderItem(quant, price, product);

                pedido.AddItem(item);
            }

            Console.WriteLine();
            Console.WriteLine("Order Summary: ");
            Console.WriteLine(pedido);



        }
    }
}
