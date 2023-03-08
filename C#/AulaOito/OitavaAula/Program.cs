using static System.Console;

namespace OitavaAula
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }
    struct Point
    {
        public int X;
        public int Y;

        public override string ToString()
        {
            return "(" + X + ")" + "(" + Y + ")";
        }
    }

    static void ExempleProblemOne()
    {

        WriteLine("A altura de quantas pessoas quer medir? ");
        int qtd = int.Parse(ReadLine());

        double[] vetor = new double[qtd];

        for (int i = 0; i < qtd; i++)
        {
            vetor[i] = double.Parse(ReadLine());
        }

        double soma = 0.0;
        for (int i = 0; i < qtd; i++)
        {
            soma += vetor[i];
        }

        double mediaAltura = soma / qtd;

        Write("A média das alturas é: " + mediaAltura.ToString("f2"));
    }
    class Program
    {
        static void Main()
        {
            WriteLine("How many products you want calculate");
            int qtd = int.Parse(ReadLine());

            Product[] p = new Product[qtd];

            for (int i = 0; i < qtd; i++)
            {
                string name = ReadLine();
                double price = double.Parse(ReadLine());
                p[i] = new Product{Name = name, Price = price};
            }

            double sum = 0.0;

            for (int i = 0; i < qtd; i++)
            {
                sum += p[i].Price;
            }

            double avarage = sum / qtd;

            WriteLine("Average Price = " + avarage.ToString("f2"));


        }
    }
}
