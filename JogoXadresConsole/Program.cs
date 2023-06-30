using static System.Console;
using tabuleiro;
using xadrez;

namespace JogoXadresConsole
{
    class Program
    {
        static void Main()
        {
            PosicaoXadrez pos = new PosicaoXadrez('c',7);

            WriteLine(pos);

            WriteLine(pos.toPosicao());
        }
    }
}
