using static System.Console;

namespace TipoDeValores {

    class Program {
        static int Adiconar20(int x){
        return x+20;
    }

    static void TrocarNome(Pessoa p1, string nomeNovo) {
        p1.Nome = nomeNovo;
    }
    public void TipoValor(){
    /* Tipo Valor
        int y = 3;
        ///Adiconar20(y); Sem retorno, somente cópia
        // com o retorno da cópia 
        y = Adiconar20(y);

        WriteLine($"o valor é {y}"); */
    }

    static void mudarImpar(int[] array){
        for (int i = 0; i < array.Length; i++){
            array[i]+=1;
        }
    }
    static void Main(string[] args) {

        int[] valores = {2,4,6,8,10,12};

        mudarImpar(valores);

        WriteLine($"Os números são {string.Join(",", valores)}");





    }
    }

}
