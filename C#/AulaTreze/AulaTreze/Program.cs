using static System.Console;
namespace AulaTreze
{
    class Program 
    {
        static void Main()
        {
            try 
            {
                int n1 = int.Parse(ReadLine());
                int n2 = int.Parse(ReadLine());

                int sum = n1+n2;
                WriteLine("\nResultado: " + sum + "\n");
            }
            catch (FormatException e) 
            {
                WriteLine("\nErro !\n" + e.Message);
                Write("\n Deseja tentar novamente? [s/n]");
                string op = ReadLine();
                if(op == "s" || op == "S")
                {
                    Write("\nVocê escolheu voltar e tentar novamente, lembre que só podem numeros inteiros !\n");
                    Main();
                }
                else 
                {
                    Write("\nVocê escolheu sair !\n");
                }
            }
        }
    }
}
