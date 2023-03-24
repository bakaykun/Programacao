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

        public override double priceTag()
        {
            return base.priceTag() + CustomsFee;

        }

    }
}