#include <stdio.h>

void Troca(int *a, int *b) {
    int temp;

    temp = *a;
    *a = *b;
    *b = temp;

} 
int main(void) {
    int x, y;
    int *px, *py;

    px = &x;
    py = &y;
    
    printf("Digite os valores: ");
    scanf("%d %d", &*px, &*py);
    
    Troca(px, py);
    
    printf(" Troquei ----> %d %d\n",*px , *py);
    
}