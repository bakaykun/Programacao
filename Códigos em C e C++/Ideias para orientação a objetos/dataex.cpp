#include <iostream>
#include "data.h"

using namespace std;

void pula() { cout << "\n\n"; }

int main(){

    cout << "\nDigite a data de hoje: \n";
    Data hoje (10,07,1938);
    
    pula();
    cout << "Hoje é dia: \n";
    Data diaHoje (05, 12, 2021);
    diaHoje.print();
    pula();

    cout << "A data de hoje he: ";
    hoje.print();

    pula();

    cout << "Digite a dia do seu nascimento:\n ";
    Data aniversario (20,05,1967);

    pula();

    aniversario.print(); 
    pula();
    aniversario.set_dia(30).set_mes(11).set_ano(1999);
    aniversario.print(); 


    pula();

  

    return 0;
}