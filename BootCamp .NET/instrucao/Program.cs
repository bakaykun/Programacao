using System;

namespace instrucao {
    class Program {
        //declarando variáveis
        static void Declaracoes(string[] args) {
            
            int numero1 = 5 , numero2 = 9;
            const int constante1 = 3;

            Console.WriteLine(numero1 + numero2 - constante1);


        }
        //instrucao if
        static void InstrucaoIf(){
            int numero = 3;

            if (numero%2 == 0){
                Console.WriteLine("é par");
            }else {
                Console.WriteLine("é impar");
            }
        }

        //instrução switch
        static void InstrucaoSwitch(){
            
            Console.WriteLine("Escolha uma letra: [A] | [B] | [C]");
            string opcao = Console.ReadLine();

            switch (opcao){
                case "A" or "a":
                    Console.WriteLine("Você escolheu a letra A/a !");
                    break;
                case "B" or "b":
                    Console.WriteLine("Você escolheu a letra B/b !");
                    break;
                case "C" or "c":  
                    Console.WriteLine("Você escolheu a letra C/c !");
                    break;
                default:
                    Console.WriteLine("Opção errada, fim do programa!");
                    break;
            }

        }

        //instrução wHILE

        static void InstrucaoWhile(){
            int contador = 0;

            while (contador < 10) {
                Console.WriteLine(contador);
                contador++;
            }
        }

        //instrução DoWhile
        static void instrucaoDoWhile(){
            int contador = 10;

            do{
                Console.WriteLine(contador);
                contador--;
            } while (contador >= 0);
        }
        //instrução For
        static void InstrcaoFor(){
           for (int i = 0; i < 10; i++) {
                Console.WriteLine(i);   
           } 
        }

        //instrucaoForeach
        static void Main(){
            int[] numeros = new int[5] {1,2,3,4,5};

            foreach (int numero in numeros){
                Console.WriteLine(numero);
            }
        }
    }
}

