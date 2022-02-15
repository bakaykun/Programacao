#include "produto.h";

Produto::Produto(){
    char nome[19];
    int ean = 0;
    float preco = 0.0;
    int quantidade = 0;
}

Produto::Produto (char n, int e, float p, int q){
    setProduto(char n, int e, float p, int q)
}

void Produto::setProduto(char n, int e, float p, int q){
    char nome[19] {n};
    int ean = e;
    float preco = p;
    int quantidade = q;
}
void impremeProduto(){

    for (int i = 0; i < 19; i++){
        cout << n[i];
    }
    cout << e;
    cout << p;
    cout << q;
}


~Produto()nome[];