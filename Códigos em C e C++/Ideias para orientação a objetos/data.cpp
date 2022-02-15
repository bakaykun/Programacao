#include "data.h"
#include <iostream>

using namespace std;

int Data::contaInstancias = 0;

Data::Data(int dd, int mm, int aa) : dia{dd}, mes{mm}, ano{aa}{
    contador = 0;
    contaInstancias++;
};

Data::~Data(){ contaInstancias--; };

Data& Data::set_dia(int dd) {
    if (dd >= 1 && dd <= 31)
        dia = dd;
    return *this;

}

Data& Data::set_mes(int mm) {
    if ( mm >= 1 && mm <= 12)
        mes = mm;
    return *this;
}

Data& Data::set_ano(int aa) {
    if ( aa > 1)
        ano = aa;
    return *this;
}

void Data::print() const{
    cout << "\n[" << dia << "/" << mes << "/" << ano << "]\n";
    contador++;
}