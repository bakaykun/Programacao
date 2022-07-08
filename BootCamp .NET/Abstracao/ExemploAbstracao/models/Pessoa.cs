namespace ExemploAbstracao.models{
    public class Pessoa{
        public string ?Nome { get; set; }
        public int Idade { get; set; }

        public void Apresentar(){
            System.Console.WriteLine($"Olá meu nome é {Nome} e tenho {Idade} anos de idade");
        }
    }
}