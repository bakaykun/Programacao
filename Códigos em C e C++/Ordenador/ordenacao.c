#include <stdio.h>
#include <stdlib.h>
#include <math.h>

/*Seguinte,tentei fazer seguindo uma dada playlist que se encontra neste link https://www.youtube.com/watch?v=79buQYoWszA
fui fazendo da aula 48 até 52 se não me engano

O último exercicio eu não sei o que errei, tentei fazer conforme eu entendia e codava, mas não deu e faltou o Qs

As funções estão abreviadas.

Site do curso que eu fui seguindo:  https://programacaodescomplicada.wordpress.com/indice/linguagem-c/

*/


int i, j,a, sequ, final = 5, aux, men, ii = 0, ff = 0, parte1, parte2, size, mei;
int ord;

 
int bs(int *vetor[5]){

    do {//ordenação

        sequ = 0;

        for (i = 0; i < 5-1; i++){

            //troca dos valores 

            if (vetor[i] > vetor[i+1]){

                aux = vetor[i];
                vetor[i] = vetor[i+1];
                vetor[i+1] = aux;
                sequ = i;
            }
        }

        final--;

    } while(sequ !=0);

    return vetor[i];
}

void ExBs()
{  
    int vetor[5] = {3,5,1,2,4};
    int *pont = &vetor;

    //exibição sem ordem

    puts("DESORDENADO: ");

    for (i = 0;i < 5; i++){

        printf("[%i]", vetor[i],".");
    }

    puts(" ");
    puts(" ");

    bs(pont);

    //exibição da ordem

    puts("ORDENADO: ");

    for (i = 0;i < 5; i++){
        
        printf("[%i]", pont[i],".");
    }

    puts(" ");

    return 0;
}

int is(int *vetor1[7]){
    
    for(i = 1; i < 7; i++){
        aux = vetor1[i];
        for(j = i; (j > 0) && (aux < vetor1[j-1]); j--){
            vetor1[j] = vetor1[j-1];
            vetor1[j-1] = aux;
        }
    }

    return aux;

}

int ExIs(){

    int vetor1[7] = {1,45,2,69,25,70,71};
    int *ponte = &vetor1;

    //exibição sem ordem

    puts("DESORDENADO: ");

    for (i = 0;i < 7; i++){

        printf("[%i]", vetor1[i],".");
    }

    puts(" ");
    puts(" ");

    is(ponte[7]);

    //exibição da ordem

    puts("ORDENADO: ");

    for (i = 0;i < 7; i++){
        
        printf("[%i]", ponte[i],".");
    }

    puts(" ");

    return 0;

}

int ss(int *yamete[7]){
    for(i = 0; i < 7; i++){
        men = i;
        for(j = i+1; j < 7; j++){
            if(yamete[j] < yamete[men]){
                men = j;
            }
        }
        if(i != men){
            aux = yamete[i];
            yamete[i] = yamete[men];
            yamete[men] = aux;
        }
    }

    return men;
}

int ExSs(){
    
    int vetor2[7] = {80,79,25,629,258,7,35};
    int *pte = &vetor2;

    //exibição sem ordem

    puts("DESORDENADO: ");

    for (i = 0;i < 7; i++){

        printf("[%i]", vetor2[i],".");
    }

    puts(" ");
    puts(" ");

    ss(pte[7]);

    //exibição da ordem

    puts("ORDENADO: ");

    for (i = 0;i < 7; i++){
        
        printf("[%i]", pte[i],".");
    }

    puts(" ");

    return 0;

}

int mg(int *vv[10], int ii, int mei, int ff){
    int *aux, men, start = 0, end= 9;
    size = ff-ii+1;

    parte1 = ii;
    parte2 = mei +1;

    aux = (int *) malloc(size*sizeof(int));

    if(aux != NULL){
        for(i = 0; i < size; i++){
           if(!start && !end){
               if(vv[parte1] < vv[parte2]){
                   aux[i]=vv[parte1++];
               }else {
                   aux[i]=vv[parte2++];
               }
               if (parte1 > mei){
                   start = 1;
               }
               if(parte2 > ff) {
                   end = 1;
               }
           }else {
               if(!start){
                   aux[i] = vv[parte1++];
               }else{
                   aux[i] = vv[parte2++];
               }
           }     
        }
        for( j = 0, a=ii; j<size; j++, a++){
            vv[a] = aux[j];
        }
    }

    free(aux);
    return vv[a];
    
}

int cob(int *vv[10], int ii, int ff){
    //fazendo a combinação das metades do vetor
    if(ii < ff){
        ord = floor((ii+ff)/2);
        cob(vv,ii,ord);
        cob(vv,ord+1,ff);
        mg(vv,ii,ord, ff);
    }

    return vv;
}


int main(int argc, char const *argv[]){
        
    int vetor3[10] = {-80,-7,205,9,58,4,15,305,40, 10};
    int *pto = &vetor3;

    //exibição sem ordem

    puts("DESORDENADO: ");

    for (i = 0;i < 10; i++){
        
        printf("[%i]", vetor3[i],".");
    }

    puts(" ");
    puts(" ");

    cob(pto[10], ii, ff);

    //exibição da ordem

    puts("ORDENADO: ");

    for (i = 0;i < 10; i++){
        
        printf("[%i]", pto[i],".");
    }

    puts(" ");

    return 0;
}
