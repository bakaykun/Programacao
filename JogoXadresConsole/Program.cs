using static System.Console;
using tabuleiro;

namespace JogoXadresConsole
{
    class Program
    {
        static void Main()
        {
            Tabuleiro tab = new Tabuleiro(8,8);

            Tela.imprimirTabuleiro(tab);
        }
    }
}
