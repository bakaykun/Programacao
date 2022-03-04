using static System.Console;
using  System;

namespace UsandoReferencia {
    class Program {

        static int Adicionar (ref int a){
            int numero = 5;
            Adicionar(ref numero);

            WriteLine($"a soma é {numero}");
            return a+=20;
        }

        static void AlterarNome(string[] nomes, string nomeVelho, string nomeNovo){
            for (int i = 0; i < nomes.Length; i++){
                if(nomes[i] == nomeVelho) 
                    nomes[i] = nomeNovo; 
            }
        }

        static ref string LocalizarNome(string[] nomes, string nomeVelho){
            for (int i = 0; i < nomes.Length; i++){
                if(nomes[i] == nomeVelho) 
                    return ref nomes[i]; 
            }

            throw new Exception("Não achou");
        }
        static void Main(string[] args) {
            string[] nomes = new string[]{"Carlos","Samara","Pedro","Sabrina"};

            WriteLine("");
            WriteLine("Treca nomes");
            WriteLine(""); 

             WriteLine($@" A a lista de nomes é
                {string.Join(", \n", nomes)}
            ");

            WriteLine("");
            WriteLine("Qual Nome será alterado: ");
            var nomeVelho = ReadLine();

            WriteLine("");
            WriteLine("Qual será o nome colocado no lugar: ");
            var nomeNovo = ReadLine();

            ref var nomeAchado = ref LocalizarNome(nomes, nomeVelho);

            if (!string.IsNullOrWhiteSpace(nomeAchado)) {
                nomeAchado = nomeNovo;

                WriteLine("");
                WriteLine("A lista Passa a ser: ");

                WriteLine($@"
                {string.Join(", \n", nomes)}
                ");

                WriteLine("");
            } else {
                WriteLine("F pra nós, deu ruim achar");
            }
        }
    }
}
