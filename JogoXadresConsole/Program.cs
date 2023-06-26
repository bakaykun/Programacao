using static System.Console;
using tabuleiro;
using xadrez;

namespace JogoXadresConsole
{
    class Program
    {
        static void Main()
        {
            Tabuleiro tab = new Tabuleiro(8,8);

            tab.colocarPeca(new Torre(tab, Cor.Preta),new Posicao(0,0));
            tab.colocarPeca(new Torre(tab, Cor.Preta),new Posicao(1,3));
            tab.colocarPeca(new Rei(tab, Cor.Preta),new Posicao(2,4));

            Tela.imprimirTabuleiro(tab);
        }
    }
}
