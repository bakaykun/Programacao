#include <stdio.h>
#include <math.h>

void cabecalho(){

    printf ("------------DIAS DE VIDA----------\n");

}

int resultado(int num, int num2, int num3){

    return (num*num2*num3);

}

void main(){

    cabecalho();

    int num =0;
    int num1 =0;
    int num2 =0;
    int multiplicacao = 0; 

    printf("Insira o dia que você nasceu: \n");
    scanf("%i",&num);

    printf("Insira o mês que voce naceu ( em número - ex: fevereiro mes; 2): \n");
    scanf("%i",&num1);

    printf("Insira o ano que tu nasceu: \n");
    scanf("%i",&num2);

    multiplicacao = resultado(num,num1,num2);
    printf("O resultado é %i", multiplicacao);

}