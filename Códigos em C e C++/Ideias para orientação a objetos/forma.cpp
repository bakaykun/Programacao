#include "forma.h"
#include <iostream>

using namespace std;

    Forma::Forma(double xx, double yy) : x{xx}, y{yy} { };
   
    void Forma::imprime_dados() {
        cout<<"Origem: " << "(" << x << "," << y << ")"<< endl;
    }