using System;

namespace Desafio{
    class Program{
        static void Main(string[] args){
             int x, auxiliar =0, soma =0, i = 1;
            
            
            while(true){
                x = int.Parse(Console.ReadLine());
                auxiliar = x;

                if (x%2 == 0){
                    soma+=x;
                } else {
                    auxiliar = x+1;
                    soma+=auxiliar;
                }

                while (i < 5){
                    auxiliar+=2;
                    soma+=auxiliar;
                    i++;
                }

                if ( x == 0) 
                    break;
                System.Console.WriteLine(soma);

                i = 1;
                soma = 0;

            }
        
        }

    }
}
