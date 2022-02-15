//verificando se o arquivo já foi incluso
#ifndef CADASTRO_H

//definindo o arquivo caso não esteja incluso
#define CADASTRO_H

//incluindo a biblioteca para string
#include <string>

//uso do escopo std
using namespace std;

//declaração da classe mãe cadastro
class Cadastro {

    //dando como sinalziador o protected, já que vamos usar o polimorfismo
    protected:
        string nome, endereco;
        int idade, ativo;

    public:
        Cadastro ();
        virtual ~Cadastro () { };

        //lançando o polimorfismo
        virtual void get_cadastro();
        virtual void imprime_cadastro();
        
};


#endif

