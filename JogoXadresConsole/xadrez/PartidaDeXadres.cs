using tabuleiro;
using System;
namespace xadrez
{
    public class PartidaDeXadres
    {
        public Tabuleiro tab {get; private set;}
        private int turno;
        private Cor jogadorAtual;
        public bool terminada {get; private set;}

        public PartidaDeXadres(){
            tab = new Tabuleiro(8,8);
            turno = 1;
            jogadorAtual = Cor.Branca;
            terminada = false;
            colocarPeca();
        }

        public void executaMovimento(Posicao origem, Posicao destino)
        {
            Peca p = tab.retirarPeca(origem);
            p.incrementarQtdMovimentos();
            Peca pecaCapturada = tab.retirarPeca(destino);
            tab.colocarPeca(p, destino);
        }

        private void colocarPeca()
        {
            tab.colocarPeca(new Torre(tab, Cor.Branca),new PosicaoXadrez('g', 6).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Branca),new PosicaoXadrez('h', 5).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Branca),new PosicaoXadrez('a', 4).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Branca),new PosicaoXadrez('b', 8).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Branca),new PosicaoXadrez('c', 3).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Branca),new PosicaoXadrez('a', 1).toPosicao());
        }
    }
}