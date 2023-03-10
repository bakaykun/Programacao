namespace OrderProducts.Entities
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product()
        {

        }

        public Product (string name, string price)
        {
            Name = name;
            Price = price;
        }
    }
}