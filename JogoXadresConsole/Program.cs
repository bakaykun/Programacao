using static System.Console;
using tabuleiro;
using xadrez;

namespace JogoXadresConsole
{
    class Program
    {
        static void Main()
        {
            try 
            {
                PartidaDeXadres partida = new PartidaDeXadres();

                Tela.imprimirTabuleiro(partida.tab);
            } 
            catch(TabException e){
                WriteLine(e.Message);
            }
        }
    }
}
