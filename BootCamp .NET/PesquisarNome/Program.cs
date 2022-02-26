using static System.Console;
using System.Collections.Generic;

namespace PesquisarNome{
    class Program {

        static bool AcharNomes(List<Pessoa> nomes, string nome){
            foreach (var item in nomes){
                if (item.Nome == nome)
                    return true;
            }
            return false;
        }
        static void Main(string[] args) {
            List<Pessoa> pessoas = new List<Pessoa>(){
                new Pessoa(){Nome = "Cleber"},
                new Pessoa(){Nome = "Kelvin"}, 
                new Pessoa(){Nome = "Bruna"}, 
                new Pessoa(){Nome = "Sabrina"}, 
                new Pessoa(){Nome = "Maria"}, 
                new Pessoa(){Nome = "Bianca"}, 
                new Pessoa(){Nome = "Ricardo"}, 
            };

            WriteLine("Insira o Nome que deseja pesquisar: ");
            var nomePesquisa = ReadLine();
            //var nome = new Pessoa(){Nome = nomePesquisa};
            var encontrado = AcharNomes(pessoas, nomePesquisa);
            WriteLine("");
            if (encontrado){
                WriteLine("A pessoa foi encontrada");
            } else { WriteLine ("A pessoa foi Não encontrada");} 

            WriteLine("");

            var quantidade = pessoas.Count;
            
            WriteLine($"A quantidade de nomes na lista é de {quantidade}");

            

        }
    }
}
