using static System.Console;

namespace ExUm 
{
    class Program 
    {
        static void Main(string[] args)
        {
            
            Pessoa primeira, segunda;
            primeira = new Pessoa();
            segunda = new Pessoa();
            
            primeira.Nome = ReadLine();
            primeira.Idade = int.Parse(ReadLine());
            primeira.Salario = double.Parse(ReadLine());

            segunda.Nome = ReadLine();
            segunda.Idade = int.Parse(ReadLine());
            segunda.Salario = double.Parse(ReadLine());

            if (primeira.Idade > segunda.Idade)
            {
                WriteLine($"a pessoa mais velha é {primeira.Nome}");
            }
            else 
            {
                WriteLine($"a pessoa mais velha é {segunda.Nome}");
            }

            WriteLine($"Salário Médio é {(primeira.Salario+segunda.Salario)/2}");           

        }
    }
}