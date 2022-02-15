#include "tempo.h"
#include <iostream>

using namespace std;

Tempo::Tempo(){
    hora = 0;
    minuto = 0;
    segundo = 0;
}

Tempo::Tempo(int hh, int mm, int ss){
    setTempo(hh,mm,ss);
};

void Tempo::setTempo(int hh, int mm, int ss){
    hora = hh;
    minuto = mm;
    segundo = ss;

};

void Tempo::imprime(){
    cout << "[" << hora << ":" <<  minuto << ":" << segundo << "]";
};

void Tempo::pula(){
    cout << "\n";
};

