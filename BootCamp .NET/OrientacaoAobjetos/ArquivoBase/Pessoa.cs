using OrientacaoAobjetos.ArquivoBase;

namespace OrientacaoAobjetos.ArquivoBase{
    public class Pessoa : Musica  {
        private string nome,dataNascimento;
        private long cpf;

        public Pessoa(string nome, string dataNascimento, long cpf, string nomeDaMusica, string generoMusical, double tempoDuracaoMusica) : 
        base( nomeDaMusica,  generoMusical,  tempoDuracaoMusica) {

            this.nome = nome;
            this.dataNascimento = dataNascimento;
            this.cpf = cpf;
        }

        public void ExibeInformacao() {

            System.Console.WriteLine(" ");
            System.Console.WriteLine($"Bem vindo {nome}");
            System.Console.WriteLine(" ");
            System.Console.WriteLine($"Sua musica Preferida é {nomeDaMusica}");
            System.Console.WriteLine($"A duração dela é de {tempoDuracaoMusica} minutos");
            System.Console.WriteLine($"O Gênero musical é {generoMusical}");
            System.Console.WriteLine(" ");
            System.Console.WriteLine($"Você nasceu em: {dataNascimento}");
            System.Console.WriteLine($"Seu CPF é: {cpf}");
            System.Console.WriteLine(" ");
        }
    }
}