using System;
namespace ExNove.Entites
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product ()
        {

        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual string priceTag()
        {
            return Name + 
            " $" + Price.ToString("F2");
        }

    }
}