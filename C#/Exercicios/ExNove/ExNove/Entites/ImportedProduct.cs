namespace ExNove.Entites
{
    public class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        {

        }

        public ImportedProduct(string name, double price, double customsFee) 
            : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public double TotalPrice()
        {
            return CustomsFee + Price;
        }

        public override string priceTag()
        {
            return Name + 
                " $" + TotalPrice().ToString("F2") + 
                " (Customs fee: $" + CustomsFee + ")";

        }

    }
}