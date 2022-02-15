#include <stdio.h>

int vertices = 8;
int matriz[8][8] = {
    {0,0,0,0,0,0,0,0},
    {0,0,0,0,0,0,0,0},
    {0,0,0,2,3,0,0,0},
    {0,4,0,3,6,6,0,0},
    {1,2,3,3,0,0,0,0},
    {0,5,0,4,0,0,0,0},
    {0,0,0,6,0,0,0,0},
    {0,0,0,7,0,0,0,0},

};

void caminhos(int matriz[8][8], int n, int inicio, int fim){
    if(inicio==fim) return;

    for (int j=0; j < n; j++){
        if (matriz[inicio][j] > 0){
            printf("\nDaqui {%i} passei pra ca {%i}", inicio, j);
            caminhos(matriz, n, j, fim);
        }
    }
}

int main() {
    caminhos(matriz, vertices, 1, 8);
    return 0;
}
