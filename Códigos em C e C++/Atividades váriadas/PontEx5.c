#include <stdlib.h>
#include <stdio.h>

int main()
{
    int i, n, *pvetor;
    float media;

    /* Define um valor para n, scanf ou n = */
    printf("Insira um valor");
    scanf("%d", &n);
    /* aloca espaco na memoria */

    pvetor = (int *)malloc(n *sizeof(int));
    
    if (!pvetor) {
        puts("Sem memória .");
        return 1;
    }

    /* A PARTIR DE AGORA VOLTAMOS PARA VETORES COMUNS */
    /* aqui uso pvetor , vamos ler um vetor */

    for (i = 0; i < n; i++) {
        scanf("%d", &pvetor[i]);
    }
    /*Professor, aqui tu pediu uma média, mas o seguinte, o código está fazendo uma soma, ou seja, neste código está sendo 
    somado o endereço de memória mais 1, ex. 000001 + i, fica 000002, ou eu estou viajando muito?pvetor na posição i
    fica o endereço mais o valor de i*/
    media = 0.0;
    for (i = 0; i < n; i++) {
        media += pvetor[i];
    }

    printf("%.2f\n", media);
    /* aqui nao preciso mais de pvetor */

    free(pvetor);
    return 0;
}