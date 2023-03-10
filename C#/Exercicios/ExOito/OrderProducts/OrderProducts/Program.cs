using System;
using static System.Console;
using OrderProducts.Entities.Enums;
using OrderProducts.Entities;

namespace OrderProducts 
{

    class Program 
    {

        static void Main()
        {

            WriteLine("ENTER CLIENT DATA: ");
            Write("Name: ");
            string name = ReadLine();
            Write("Email: ");
            string email = ReadLine();
            WriteLine("Birth Date: ");
            DateTime bhtDate = DateTime.ParseExact(ReadLine(), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);

            Client c1 = new Client(name, email, bhtDate);

            WriteLine("Enter Order Data: ");
            OrderStatus status = Enum.Parse<OrderStatus>(ReadLine());

            Order order = new Order(DateTime.Now, status, c1);

            Write("How many items to this order? ");
            int nOrd = int.Parse(ReadLine());

            for (int i = 1; i <= nOrd; i++)
            {
                Write($"Product item #{i}\n");
                Write("Product Name: ");
                string tProdName = ReadLine();
                Write("Product Price: ");
                double tProdPrice = double.Parse(ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
                Product product = new Product(tProdName, tProdPrice);
                
                Write("Quantity: ");
                int qtd = int.Parse(ReadLine());

                OrderItem orderItem = new OrderItem(qtd, tProdPrice, product);

                order.AddItem(orderItem);
                

            }

            Write(" \n");
            WriteLine(order);
            Write(" ");


        }
    }
}