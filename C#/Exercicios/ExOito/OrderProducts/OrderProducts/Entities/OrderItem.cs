using System.Collections.Generic;
using System.Text;

namespace OrderProducts.Entities
{
    public class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }

        public Product Product {get;set;}

        public OrderItem()
        {

        }

        public OrderItem(int quantity, double price, Product product) {
            Quantity = quantity;
            Price = price;
            Product = product;
            
        }

        public double SubTotal(){
            return Quantity*Price;
        }

        public override string ToString()
        {
            StringBuilder exbOrd = new StringBuilder();
            exbOrd.Append(Product.Name);
            exbOrd.Append(", ");
            exbOrd.Append(Price);
            exbOrd.Append(", ");
            exbOrd.Append("Quantity: ");
            exbOrd.Append(Quantity);
            exbOrd.Append(" Subtotal: ");
            exbOrd.Append(SubTotal());
            return exbOrd;
        }
    }
}