#include <iostream>
#include "tempo.h"

using namespace std;

int main(){

    Tempo padrao;
    Tempo custom(11,25,36);
    Tempo linha;

    cout << "Hora Padrão: ";
    padrao.imprime();

    linha.pula();

    cout << "Hora Customizada: ";
    custom.imprime();

    linha.pula();

    padrao.setTempo(23,20,30);

    cout << "Hora Modificada: ";
    padrao.imprime();


    return 0;
}