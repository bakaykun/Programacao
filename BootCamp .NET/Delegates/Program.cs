using Delegates.models;
using static System.Console;

/* Delegates apenas
Operacao op = new Operacao(Calculadora.Somar);
//com multicast
op+=Calculadora.Subtrair;

op.Invoke(10,20);
public delegate void Operacao(int x, int y);

*/

//Usando Eventos

Matematica operacao = new Matematica(35,40);
operacao.Somar();


