//inclusão das classes de cabecalho em estilo TAD
#include "tiposCadastros.h"

//bibliotecas nativas
#include <iostream>
#include <stdlib.h>
#include <locale>
//para facilitar o código
using namespace std;

//Declaração de vaiáveis usadas no código todo
string estado;
int ativo;

//função que eu sempre faço só para pular linha
void pula() { cout << "\n" ; }

//Função de confirmar o cadastro
void confirma(){

    cout << "Deseja confirmar o cadastro ? " << endl;
    cout << "Para sim tecle [1] / não tecle [0]" << endl;
    cin >> ativo;

    if ( ativo == 1) {

        estado = "Ativo";
            
    };

}


//implementando os construtores
Cadastro::Cadastro ()  {
    nome = ' ';
    endereco = ' ';
    idade = 0;
    ativo = 0;

};

Cliente::Cliente(){
    Cadastro();
};

Fornecedor::Fornecedor() {
    Cadastro();
    tipo_produto = ' ';

};

Adminstrador::Adminstrador(){
    Cadastro();
    int numSres = 0;
    string cargo = " ";
}

//declarando a função geral da superClasse Cadastro ( para pegar os valores)
void Cadastro::get_cadastro() {
    setlocale (LC_ALL, "portuguese");

    cout << "Insira o seu nome: " << endl;
    fflush(stdin);
    getline (cin,nome);
    pula();

    cout << "Insira seu Endereço: "<< endl;
    fflush(stdin);
    getline (cin,endereco);
    pula();

    cout << "Insira a sua idade: "<< endl;

    cin >> idade; 

    if (idade < 18) {

        cout << "Você não pode fazer o cadastro" << endl;
        system("pause");
        pula();
        cout << "ERRO /89";
        pula();
        exit(true);

    }

    confirma();

    };

//para imprimir os valores
void Cadastro::imprime_cadastro(){
    cout << "#### DADOS DO CADASTRO ####" << endl;
    pula();
    cout << "NOME: " << nome << endl;
    cout << "Logradouro: " << endereco << endl;
    cout << "Idade " << idade << endl; 
    cout << "Situação do cadastro: " << estado << endl;

};

//Declarando as partes especídifcas

    //Fornecedor
void Fornecedor::get_cadastro(){
    cout << "Que tipo de produto você vende? " << endl;
    fflush(stdin);
    getline(cin, tipo_produto);
    Cadastro::get_cadastro();

};

void Fornecedor::imprime_cadastro(){
    cout << "PRODUTO QUE VENDE: " << endl;
    Cadastro::imprime_cadastro();
};

    //Adminstrador
void Adminstrador::get_cadastro(){
    cout << "Numero do setor que vai cadastrar: " << endl;
    fflush(stdin);
    cin >> numSres;

    pula();

    cout << "qual o cargo a ser cadastrado: " << endl;
    fflush(stdin);
    getline(cin, cargo);

    pula();

    Cadastro::get_cadastro();
        
};

void Adminstrador::imprime_cadastro(){
    cout << "SETOR:  " << endl;
    cout << numSres;

    pula();

    cout << "CARGO: " << endl;
    cout << cargo;

    pula();

    Cadastro::imprime_cadastro();
        
};


