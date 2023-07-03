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

                while(!partida.terminada)
                {
                    Clear();
                    Tela.imprimirTabuleiro(partida.tab);

                    WriteLine();
                    Write("Origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                    Write("Destino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

                    partida.executaMovimento(origem, destino);

                }

              
            } 
            catch(TabException e){
                WriteLine(e.Message);
            }
        }
    }
}
