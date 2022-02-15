#include <stdio.h>
#include <stdlib.h>
#include <locale.h>
/*
Kelvin Patrick dos Santos, código do exercicio 6, não consegui fazer com grafo pois,
a ideia de busca ainda está abstrata em minha cabeça.
*/
//Declaração de cariáveis globais para facilitar o código
int i, j, k;
char caminho, final;
//Imprimindo 3 possíveis rotas
void verificando(int matriz[11][12]){
for (i = 0; i < 11; i++){
for (j = 0; j < 12; j++){
do{
if (matriz[i][j] == 0){
printf("##");
}else if(matriz[i][j] == 2) {
printf("[]");
} else{
if(matriz[i][j] == 1){
printf("--");
} else {
printf("GG");
}
}
}while(matriz[11][12] == 3);
}
printf("\n");
}
}
//verificando a posição dos caminhos possíveis
void pAresta(int matriz[11][12]){
puts(" ");
puts("Os caminhos possíveis são");
for (i = 0; i < 11; i++) {
for ( j = 0; j < 12; j++){
if(matriz[i][j] == 1){
printf("Linha{%i} | Coluna{%i}\n", i,j);
}
}
puts(" ");
}
}
//verificando posição da estrela
void pFinal(int matriz[11][12]){
puts(" ");
printf("A estrela está na: ");
for (i = 0; i < 11; i++) {
for ( j = 0; j < 12; j++){
if(matriz[i][j] == 3){
printf("Linha{%i} | Coluna{%i}", i,j);
}
}
puts(" ");
}
}
int main(){
//Definindo localidade do computador
setlocale(LC_ALL,"Portuguese");
//Declaração da matriz
int matriz[11][12]={
{0,0,0,0,0,0,0,0,0,0,0,0},
{0,2,2,2,2,2,2,1,1,1,1,1},
{0,2,2,2,2,2,2,1,2,2,2,0},
{0,2,2,2,1,1,1,1,1,2,2,0},
{0,2,2,2,1,2,1,2,1,1,1,0},
{1,1,1,1,1,2,1,2,2,2,1,0},
{0,2,2,2,2,2,3,2,2,2,1,0},
{0,2,2,2,2,2,2,2,2,2,1,0},
{0,2,2,2,2,2,2,2,2,2,1,0},
{0,2,2,2,2,2,2,2,2,2,1,1},
{0,0,0,0,0,0,0,0,0,0,0,0},
};
//chmada da função
verificando(matriz);
puts("");
pAresta(matriz);
puts("");
pFinal(matriz);
}