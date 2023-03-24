using System;
namespace ExNove.Entites
{
    public class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct()
        {

        }

        public UsedProduct(string name, double price, DateTime manufactureDate) 
            : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string priceTag()
        {
            return base.priceTag() + " (USED)" + "MANUFACTURED DATE: " + 
            ManufactureDate.ToString("dd/MM/yyyy");
        }
    }
}