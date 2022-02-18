namespace OrientacaoAobjetos.ArquivoBase{
    public class Musica{
        protected string nomeDaMusica, generoMusical;
        protected double tempoDuracaoMusica;

        public Musica(string nomeDaMusica, string generoMusical, double tempoDuracaoMusica){
            
            this.nomeDaMusica = nomeDaMusica;
            this.tempoDuracaoMusica = tempoDuracaoMusica;
            this.generoMusical = generoMusical;
        }

    }
}