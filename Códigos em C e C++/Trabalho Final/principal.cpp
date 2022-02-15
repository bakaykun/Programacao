//perguntar para o professor, sobre o bug do setLocale e sobre pegar os valores do cin para classe em time

//inclusão das classes de cabecalho em estilo TAD
#include "tiposCadastros.h"

//bibliotecas nativas
#include <iostream>
#include <stdlib.h>

//para facilitar o código
using namespace std;

//Funções para auxiliar no código
void espaco() { cout << "\n" ;}
void menu() {
    cout << "*****************************************" << endl;
    cout << "*****************************************" << endl;
    cout << "******** TELA DE CADASTRO 2.01 **********" << endl;
    cout << "*****************************************" << endl;
    cout << "*****************************************" << endl;

    espaco();

    cout << "*****************************************" << endl;
    cout << "* Seleciono o usuário para cadastro    *" << endl;
    cout << "* {A}Cliente............................*" << endl;
    cout << "* {B}Fornecedor.........................*" << endl;
    cout << "* {C}Adminstrador.......................*" << endl;
    cout << "*****************************************" << endl;
    espaco();
};


int main(){
  
    //Declaração das classes
    Cadastro* cliente = new Cliente();
    Cadastro* fornecedor = new Fornecedor();
    Cadastro* adminstrador = new Adminstrador();

    //Variáveis a serem usasdas na main
    char op;
    string nome, endereco;
    int idade, situ;

    //Função que mostra o cabecalho
    menu();

    //corpo do código em si
    
    fflush(stdin);
    cin >> op;
    
    switch (op){
    case 'A':
    case 'a':

        cliente->get_cadastro();
        system("pause");
        system("cls");
        cliente->imprime_cadastro();

        break;
    
    case 'B':
    case 'b':

        fornecedor->get_cadastro();
        system("pause");
        system("cls");
        fornecedor->imprime_cadastro();

        break;

    case 'C':
    case 'c':

        adminstrador->get_cadastro();
        system("pause");
        system("cls");
        adminstrador->imprime_cadastro();;

        break;

    default:
        cout << " Ai não colega, ai tu quebra meu código" << endl;
        cout << "Fim do programa :(" << endl; 
        break;
    }

    
}
