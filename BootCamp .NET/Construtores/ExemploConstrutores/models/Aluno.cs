namespace ExemploConstrutores.models
{
    public class Aluno : Pessoa
    {
        private string Disciplina;
        //passando as regras da classe pessoa para a classe Aluno
        public Aluno(string nome, string sobrenome, string diciplina) : base(nome, sobrenome)
        {
            this.Disciplina = diciplina;
        }

        public void ShowDisc(){
            System.Console.WriteLine("Diciplina: " + Disciplina);
        }
    }
}