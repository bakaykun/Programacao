#include <stdlib.h>
#include <stdio.h>

int main(){

    int i, n, *pvetor, j;
    float media, aux = 0, numMaiores= 0;

    /* Define um valor para n, scanf ou n = */
    puts("Insira um valor para alocação e em seguida os numeros a serem alocados: ");
    scanf("%d", &n);

    /* aloca espaco na memoria */

    pvetor = (int *)malloc(n *sizeof(int));

    if(!pvetor) {
        puts("Sem memória .");
        return 1;
    }
    /* aqui uso pvetor , vamos ler um vetor */

    for (i = 0; i < n; i++) {
        scanf("%d", pvetor + i);
    }


    /* faco alguma coisa */
    /*Modifiquei para poder realizar a média, já que o o anunciado permitia a modifcação*/
    media = 0.0;
    for (i = 0; i < n; i++) {
        aux += *(pvetor + i);
        
        
    }
    /*Cálculo da média*/
    media = aux/n;

    printf("A media e: %.2f \n \n", media);
    
    for(j = 0; j < n; j++){

        //verificação dos maiores valores: 

        if(*(pvetor + j) > media){
            numMaiores = *(pvetor + j);
            puts("Os numeros maiores sao: ");
            printf("|%.2f |", numMaiores);
        }
    }


    /* aqui nao preciso mais de pvetor */

    free(pvetor);
    return 0;
}