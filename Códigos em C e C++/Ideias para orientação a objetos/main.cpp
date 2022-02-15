#include "forma.h"
#include "retangulo.h"
#include "circulo.h"
#include <iostream>

using namespace std;

void pula() { cout << "\n\n";}

int main() {
    Forma* ponto1 = new Forma{ 10.0, 20.5};
    cout << "Forma: " << endl;
    ponto1->imprime_dados();
    cout << "Area = "  << ponto1->area();

    pula();

    cout << "Retangulo " << endl;
    Forma* ret1 = new Retangulo{0,0,15,20};
    ret1->imprime_dados();


    pula();

    cout << "Circulo: " << endl;
    Forma* circ = new Circulo (2,2.5, 10);
    circ->imprime_dados();
    
    return 0;
}


/*Forma* ponto1 = new Forma{ 10.0, 20.5};
cout << "Forma: " << endl;
ponto1->imprime_dados();
cout << "Area = "  << ponto1->area();

pula();

cout << "Retangulo " << endl;
Forma* ret1 = new Retangulo{0,0,15,20};
ret1->imprime_dados();


pula();

cout << "Circulo: " << endl;
Forma* circ = new Circulo (2,2.5, 10);
circ->imprime_dados();*/
    
    