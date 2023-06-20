using ExOnze.Entities;
using ExOnze.Entities.Exception;
using static System.Console;
using static System.Globalization.CultureInfo;

namespace ExOnze 
{

    class Program 
    {

        static void Main() 
        {

            Write("Coloque os dados da conta: \n");
            Write("Número: ");
            int n = int.Parse(ReadLine());
            Write("Cliente: ");
            string nome = ReadLine();
            Write("Limite inicial: ");
            double lmt = double.Parse(ReadLine());
            Write("Limite de Saque: ");
            double sq = double.Parse(ReadLine());

            Write(" ");

            Account ac = new Account(n,nome,lmt,sq);


            Write("Coloque o valor para saque: ");
            double vsq = double.Parse(ReadLine());

            try
            {
                ac.Saque(vsq);
            }
            catch(DomainException e)
            {
                WriteLine("Erro: " + e.Message);
            }




        }

    }
}
