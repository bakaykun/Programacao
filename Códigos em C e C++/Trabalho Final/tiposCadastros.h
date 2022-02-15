//Verificando se o arquivo foi ou não incluso.
#ifndef TIPOSCADASTROS_H
#define TIPOSCADASTROS_H

#include "cadastro.h"

class Cliente : public Cadastro {
    //Deixando somente como publico porque não tem outra variação
    public:
        Cliente ();
        ~Cliente() { };
    
};

class Fornecedor : public Cadastro {
    //privando pois não será compartilhada
    private:
        string tipo_produto;

    public:
        Fornecedor();
        ~Fornecedor()  { };

        void get_cadastro();
        void imprime_cadastro();
}; 


class Adminstrador : public Cadastro {
    //privando pois não será compartilhada
    private:
        int numSres;
        string cargo;

    public:
        Adminstrador();
        ~Adminstrador() { };

        void get_cadastro();
        void imprime_cadastro();
};

#endif