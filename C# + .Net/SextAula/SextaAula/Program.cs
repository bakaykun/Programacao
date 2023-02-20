using static System.Console;
using System.Globalization;

namespace SextaAula
{
    class Program 
    {
        static void Main(string[] args)
        {
            Produto prod1;
            prod1 = new Produto();

            Write("Insira O nome do produto: ");
            prod1.Nome = ReadLine();
            Write("Insira o preço do produto: ");
            prod1.Preco = double.Parse(ReadLine(), CultureInfo.InvariantCulture);
            Write("Quantidade no Estoque: ");
            prod1.Quantidade = int.Parse(ReadLine(), CultureInfo.InstalledUICulture);

            WriteLine($"Dados do Produto: {prod1}");
               

        }
    }

}
