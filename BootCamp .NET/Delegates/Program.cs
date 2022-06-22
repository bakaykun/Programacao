using Delegates.models;
using static System.Console;

Operacao op = new Operacao(Calculadora.Somar);
//com multicast
op+=Calculadora.Subtrair;

op.Invoke(10,20);
public delegate void Operacao(int x, int y);
