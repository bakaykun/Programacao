/*
paper beta de grafos em linguagem C by Cooler_
contato: c00f3r[at]gmail[dot]com
O que é ?
  Em matemática e ciência da computação, grafo é o objeto básico de estudo da 
teoria dos grafos. Tipicamente, um grafo é representado como um conjunto de 
pontos (vértices) ligados por retas (as arestas). Dependendo da aplicação, as 
arestas podem ser direcionadas, e são representadas por "setas".
No que vai usar ?
  Os grafos são muito úteis na representação de problemas da vida real, em 
vários campos profissionais. Por exemplo, pode-se representar um mapa de 
estradas através dos grafos e usar algoritmos específicos para determinar 
o caminho mais curto entre dois pontos, ou o caminho mais económico. Assim, 
os grafos podem possuir também pesos (ou custo), quer nas arestas quer nos 
vértices, e o custo total em estudo será calculado a partir destes pesos.
  Grafos podem ser utilizados também em redes PERT no âmbito do planejamento 
de projetos. Neste caso, a cada aresta está associado o custo de execução, e
 as tarefas precedentes de uma outra serão suas afluentes.
  Outro exemplo é o caso das redes de computadores, sendo cada terminal representado
por um vértice, o cabo de rede pelas arestas e o custo associado a latência, por
exemplo, ou o número de máquinas que a comunicação atravessa entre os nós. É nestes 
princípios que assenta todo o protocolo IP que torna possível a Internet ser uma realidade.
vertice A e B:
(A)  (B)
arco(também aresta) entre A e B
(A)<------>(B)
A para B e B para A
grafo direto
e
(A)------(B)
A para B e B para A
grafo indireto
diferença que no direto tu pode especificar somente uma cardinalidade
(A)------>(B)
logo A para B somente
-------------------------------
vejamos
             
(A)<------>(B)
  |          \
   \--->(C)   \--->(D)
logo a matriz
   A B C D
 +----------
A| 0 1 1 0
B| 1 0 0 1
C| 0 0 0 0
D| 0 0 0 0
quando programamos com grafos sem peso"sem valores" 
indicamos arcos com uso do 1(tem arco com..) e 0(não tem arco),
Para saber melhor caminho entre arcos quando se tem grafos por pesos(com valores), usa-se
o algoritmo de dijkstra..
Por exemplo ,precisamos chegar em D,arco de "A" para "C" e "D" tem um custo de 50,
e de "A" para "B" e "D" tem custo de 40,este algoritmo nos mostra o caminho de menos gasto
entre os vertices...
O Algoritmo de Bellman-Ford é um algoritmo de busca de caminho mínimo em um 
dígrafo ponderado, ou seja, cujas arestas têm peso, inclusive negativo. O Algoritmo 
de Dijkstra resolve o mesmo problema, em um tempo menor, porém exige que todas as arestas 
tenham pesos positivos. Portanto, o algoritmo de Bellman-Ford é normalmente usado apenas 
quando existem arestas de peso negativo.
exemplo teste bellman-ford
*/

#include <stdio.h>

#define EF 1000
#define NIL -1
#define TRUE 1
#define FALSE 0
#define BUF 100

int grafo[BUF][BUF][2],d[BUF],pi[BUF];
int nn,en;

void ISS(int s);
void R(int u,int v);
int Bellman_Ford(int s);
void PrintCaminho(int s, int v);

int main(int argc, char *argv[])
{
    int i,j,k,c,s,v,peso;
    
    puts("\n numero de vertices que tera o grafo : ");
    scanf("%d",&nn);
    puts("\nnumero de arcos presente no grafo : ");
    scanf("%d",&en);
    
    fprintf(stdout,"\nagora digite %d numero de arcos entre dois vertices \n junto com seus pesos \n",en);
    
    for(i=0;i<en;i++)
    {
        fprintf(stdout,"\npar com %d e com (U V W) : ",i+1);
        scanf("%d %d %d",&j,&k,&peso);
        j--;
        k--;
        grafo[j][k][0]=1;
        grafo[j][k][1]=peso;
    }
    
    fprintf(stdout,"\no grafo tem %d vertices e %d arcos foram criados\n",nn,en);
    
    puts("\n listando dados do grafo : \n");
    for(i=0;i<nn;i++)
    {
        c=1;
        fprintf(stdout,"\nanalisando %d  : \n",i+1);
        
        for(j=0;j<nn;j++)
        if(grafo[i][j][0]==1)
        {
          fprintf(stdout,"(%d) vertice = %d e peso = %d\n",c,j+1,grafo[i][j][1]); 
          c++;
        }
    }
    
    puts("\nprecine qualquer tecla para calcular o grafo\n");
    
    do{
        puts("\n digite numero do vertice: ");
        scanf("%d",&s);
        c=Bellman_Ford(s-1);
        if(c==TRUE)
         puts("\nAqui fonte única algoritmo Shortest Caminho é logicamente aplicavel\n");
        else 
         puts("\nAqui fonte única algoritmo Shortest Caminho é logicamente nao aplicavel\n");
        
        puts("\ndigite numero da aresta de destino : ");
        scanf("%d",&v);
        printf("\nmenor caminho da aresta (%d) para aresta (%d)  : \n\n",s,v);
        
        PrintCaminho(s-1,v-1);
        fprintf(stdout,"\n\ne a distancia entre as duas arestas he %d",d[v-1]);
        
        puts("\n\ndigite 1 apra continuar calculando\n ou 2 para terminar calculo\n\n escolha um : ");
        
        scanf("%d",&c);
    }while(c!=2);
  
    puts("\ndigite uma tecla para terminar...");	
    return 0;
}

void ISS(int s)
{
    int i;
    for(i=0;i<nn;i++)
    {
     d[i]=EF;
     pi[i]=NIL;
    }
    d[s]=0;
}

void R(int u,int v)
{
    if(d[v]>(d[u]+grafo[u][v][1]))
    {
        d[v]=(d[u]+grafo[u][v][1]);
        pi[v]=u;
    }
}

int Bellman_Ford(int s)
{
    int i,j,k;
    ISS(s);
    for(i=0;i<(nn-1);i++)
    {
        for(j=0;j<nn;j++)
         for(k=0;k<nn;k++)
          if(grafo[j][k][0]==1)
           R(j,k);
    }
    for(i=0;i<nn;i++)
     for(j=0;j<nn;j++)
      if(grafo[i][j][0]==1)
      {
        if(d[j]>(d[i]+grafo[i][j][1]))
        return FALSE;
      }
    return TRUE;
}

void PrintCaminho(int s, int v)
{
     if(v==s)printf("  %d  ",s+1);
      else if(pi[v]==NIL)
       fprintf(stdout,"nao tem caminho %d a %d ",s+1,v+1);
     else
     {
      PrintCaminho(s,pi[v]);
      fprintf(stdout,"  %d  ",v+1);
     }
}