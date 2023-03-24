using static System.Console;
using static System.Globalization.CultureInfo;
using ExNove.Entites;
using System.Collections.Generic;
namespace ExNove
{
    class Program
    {
        public static void Main()
        {
            List<Product> lstProduct = new List<Product>();

            Write("Enter the number of products: ");
            int n = int.Parse(ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Write("Commum, used or imported [c|u|i]?");
                char op = char.Parse(ReadLine());

                Write("Name: ");
                string name = ReadLine();
                Write("Price: ");
                double price = double.Parse(ReadLine());  

                if( op == 'c' || op == 'C') 
                {
                    lstProduct.Add(new Product(name, price));
                } 
                else if (op == 'i' || op == 'I' ) 
                {
                    Write("Customs Fee: ");
                    double customsFee = double.Parse(ReadLine());
                    lstProduct.Add(new ImportedProduct(name, price, customsFee));
                } 
                else 
                {
                    Write("Manufactured Date: (DD/MM/YYYY)");
                    DateTime mfDate = DateTime.ParseExact(ReadLine(), "dd/MM/yyyy", InvariantCulture);
                    lstProduct.Add(new UsedProduct(name,price, mfDate));
                }
            }

            WriteLine("-----------\n");

            Write("Price Tags \n");

        }

             
    }
}

