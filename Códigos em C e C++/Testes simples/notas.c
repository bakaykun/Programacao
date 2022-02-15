#include <stdio.h>
#include <stdlib.h>
#define true 1
#define false 0


int main(){
    int i, j;
    char graf[4][4] = {
        {'*', '*', '*', '*'},
        {'*', '*', '*', '*'},
        {'*', '*', '*', '*'},
        {'*', '*', '*', '*'}
    };

    for(i = 0; i < 4; i++){
        for(j = 0; j < 4; j++){
            printf("%c*", graf[i][j]);
        }
        printf("\n");
    }

}