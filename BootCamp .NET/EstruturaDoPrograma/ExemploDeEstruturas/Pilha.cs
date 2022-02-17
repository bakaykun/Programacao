using System;
namespace EstruturaDoPrograma.ExemplosDeEstruturas{
    //implemtnetação do conceito de Pilha, o ultimo que entra é o primeiro que sai
    public class Pilha {
        Posicao primeiro;

        public void Empilha(object item) {
            primeiro = new Posicao(primeiro, item);
        }

        public object Desempilha(){
            if ( primeiro == null) {
                throw new InvalidOperationException("A pilha tá vazia");
            }

            object resultado = primeiro.item;
            primeiro = primeiro.proximo;
            return resultado;
        }

    class Posicao {
        public Posicao proximo;      
        public object item;
        public Posicao(Posicao proximo, object item){
            this.proximo = proximo;
            this.item = item;
        }


    }

    }

}