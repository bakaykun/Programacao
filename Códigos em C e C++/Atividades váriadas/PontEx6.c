#include <stdlib.h>
#include <stdio.h>

int main(){

    int i, n, *pvetor;
    float media;

    /* Define um valor para n, scanf ou n = */
    printf("Insira um valor");
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
    /*Neste caso, levando em conta o ex 5, está somando o valor mesmo do endereço +i, ou seja a posição 0  + 1, que vira 3, mas não é média*/
    media = 0.0;
    for (i = 0; i < n; i++) {
        media += *(pvetor + i);
    }
    printf("%.2f\n", media);

    /* aqui nao preciso mais de pvetor */

    free(pvetor);
    return 0;
}