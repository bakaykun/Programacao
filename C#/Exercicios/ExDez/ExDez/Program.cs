using static System.Console;
using System.Collections.Generic;
using ExDez.Entities;

namespace ExDez{
    class Program {
        static void Main()
        {
            double soma = 0.0;
            List<TaxaImposto> list = new List<TaxaImposto>();
            WriteLine("Numero de pagadores: ");
            int n = int.Parse(ReadLine());

            for(int i = 1; i <= n; i ++)
            {
                WriteLine($"Contribuinte #{i}");
                Write("Pessoa Física ou Juridica? (f/j) ");
                char op = char.Parse(ReadLine());

                Write("Nome: ");
                string nome = ReadLine();
                Write("Ganhos Anuais: ");
                double ganhos = double.Parse(ReadLine());
                if(op == 'f' || op == 'F'){
                    Write("Gastos com saude: ");
                    double gastos = double.Parse(ReadLine());
                    list.Add(new PeFisica(nome, ganhos, gastos));
                } else 
                {
                    Write("Numero de Funcionarios: ");
                    int nFunc = int.Parse(ReadLine());
                    list.Add(new PeJuridica(nome, ganhos, nFunc));
                }

                
            }

            WriteLine("Taxas a pagar: ");

            foreach (TaxaImposto pagador in list)
            {
                double taxa = pagador.PagarTaxa();
                WriteLine( pagador.Nome + ": $" + pagador.PagarTaxa().ToString("F2"));
                soma+=taxa;
            }

            WriteLine(" ");
            Write("Taxas Totais: " + soma.ToString("F2"));

        }
    }
}
