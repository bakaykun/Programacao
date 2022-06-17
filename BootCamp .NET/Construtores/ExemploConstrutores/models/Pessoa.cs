using static System.Console;

namespace ExemploConstrutores.models{
    public class Pessoa{

        //sem readonly
        //private  string ?Nome;
        //private string ?Sobrenome;

        //com readonly, só é alterado no construtor
        private readonly string ?Nome;
        private readonly string ?Sobrenome;

        /*public Pessoa(){
            Nome = string.Empty;
            Sobrenome = string.Empty;
        }*/

        public Pessoa(string nome, string sobrenome){
            this.Nome = nome;
            this.Sobrenome = sobrenome;
        }

        public void Apresentar(){
            WriteLine($"Olá meu nome é {Nome} {Sobrenome}");
        }
    }
}