#include "circulo.h"
#include <iostream>

using namespace std;


Circulo::Circulo(){
    radiano = x = y = 0.0;
}

Circulo::Circulo(float r, float x, float y){
    radiano = r;
    x = x;
    y = y;
}


float Circulo::area(){
    return (radiano*radiano)*3.14;
}

float Circulo::diametro(){
    return radiano*2;
}

void Circulo::set_radiano(float r){
    if (r > 0){
        radiano = r;
    }else {
        radiano = 0;
    }
}

void Circulo::set_origem(float x, float y){
    x = x;
    y = y;
}

float Circulo::get_radiano(){
    return radiano;
}

void Circulo::imprime(){
    cout << "[  o Raio eh:  " << radiano << "X  eh:  ," << x << "Y eh:  " << y << " ]";
}
