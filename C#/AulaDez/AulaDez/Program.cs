using static System.Console;
using AulaDez.Enities;
using AulaDez.Enities.Enums;


namespace AulaDez
{
    class Program 
    {
        static void Main() 
        {
            Order order = new Order {
                Id = 1890,
                Moment = System.DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            WriteLine(order);

            string status = OrderStatus.PendingPayment.ToString();

            WriteLine(status);

            OrderStatus os = Enum.Parse<OrderStatus>("Processing");

            WriteLine(os);
        }
    }
}
