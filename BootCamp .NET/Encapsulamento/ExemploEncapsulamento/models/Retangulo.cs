namespace ExemploEncapsulamento.models{
    public class Retangulo{
        private double Comprimento { get; set; }
        private double Largura { get; set; }

        public void definirMedidas(double comprimento, double largura){
            if (comprimento > 0 && largura > 0){
                this.Comprimento = comprimento;
                this.Largura = largura;
            } else {
                Console.WriteLine("F pra tu meu rei, deu boa não, só pode numero prositivo animal");
            }
        }

        public double obterArea(){
            return Comprimento*Largura;
        }
    }
}