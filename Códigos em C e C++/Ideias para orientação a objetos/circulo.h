#ifndef CIRCULO_H
#define CIRCULO_H

class Circulo {
private:
    float radiano, x, y;
public:
//contrutor
    Circulo();
    Circulo(float, float, float);
//destrutot
    ~Circulo() { };

//funções membro de interface
    float area();
    float diametro();
    void perimetro(float);
    void set_radiano(float);
    void set_origem(float, float);
    float get_radiano();
    void imprime();
    

};


#endif