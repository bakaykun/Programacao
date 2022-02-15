#include <stdio.h>

void troca(int *a, int *b) {

    int temp;

    temp = *a;
    *a = *b;
    *b = temp;
} 

/* Fim de troca */

int main() {

    int x, y;
    
    printf("Digite dois Valores:  ");
    scanf("%d %d", &x, &y);
    troca(&x, &y);

    printf(" Troquei ----> %d %d\n", x, y);
    
}