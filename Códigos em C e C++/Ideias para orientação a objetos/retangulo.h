#ifndef RETANGULO_H
#define RETANGULO_H

#include "forma.h"


class Retangulo : public Forma {
    private:
        double b, h;
    public:
    //o construtor tem que receber os parametros da mae e depois do filho
        Retangulo(double = 0, double = 0, double = 0, double = 0);
        ~Retangulo() { };

    void imprime_dados();
    double area();
};



#endif