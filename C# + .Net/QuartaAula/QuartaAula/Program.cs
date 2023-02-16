using static System.Console;

string[] valor = ReadLine().Split(' ');
int x = int.Parse(valor[0]);
int y = int.Parse(valor[1]);


while(x != 0 && y != 0){
    if(x > 0 && y > 0){
        WriteLine("Primeiro quadrante");
    } else if( x > 0 && y < 0){
        WriteLine("Segundo quadrante");
    } else if ( x < 0 && y < 0){
        WriteLine("Terceiro quadrante");
    } else {
        WriteLine("Quarto quadrante");
    }

    valor = ReadLine().Split(' ');
    x = int.Parse(valor[0]);
    y = int.Parse(valor[1]);
}