namespace CadastroDeAluno
{
    public class Aluno {
        public string Nome;
        public decimal Nota;

        public Aluno(){    
        }

        public void GetNome(string nome){
            this.Nome = nome;
        }

/*         public void SetNome(){
            System.Console.WriteLine(Nome);
        } */

        public void GetNota( decimal nota){
            this.Nota = nota;
        }

/*         public void SetNota(){
            System.Console.WriteLine(Nota);
        } */

    }
}