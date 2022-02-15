#include <stdio.h>

void misterio(char *n);

int main(void)
{
    char nome[41];
    gets(nome);
    misterio(nome);
    return 0;
}

void misterio(char *n){
    while (*n != ' ') n++;

        n++;
    puts(n);
}

/*Tem a mesma função do 4, só muda a forma de escrita*/