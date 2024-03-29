using OrderProducts.Entities.Enums;
using System.Text;
using System.Collections.Generic;
using System;

namespace OrderProducts.Entities
{
    public class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public List<OrderItem> Items {get; set;} = new List<OrderItem>();

        public Client Client {get; set;}

        public Order()
        {

        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
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
            double sum = 0.0;
            foreach (OrderItem item in Items)
            {
                sum += item.SubTotal();
            }

            return sum;
        }

        public override string ToString()
        {
            StringBuilder exb = new StringBuilder();
            exb.AppendLine("Order Summary: ");
            exb.AppendLine("Order moment: " + Moment.ToString("dd/MM/yyy HH:mm:ss"));
            exb.AppendLine("Status: " + Status);
            exb.AppendLine("Client: ");
            exb.Append(Client.Name);
            exb.Append(" ");
            exb.AppendLine(Client.BirthDate.ToString("dd/MM/yyy"));
            exb.Append(" - ");
            exb.AppendLine(Client.Email);
            exb.AppendLine("Order items: ");
            foreach (OrderItem item in Items)
            {
                exb.AppendLine(item.ToString());
            }

            exb.AppendLine("Total: R$" + Total().ToString("F2"));

            return exb.ToString();
        }
    }
}