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
        static void Main(string[] args) {

            Pessoa p1 = new Pessoa();
            p1.Nome = "Kelvin";
            p1.idade = 23;
            p1.Documento = "7895965635";

            TrocarNome(p1, "Marcósias");
            Pessoa p2 = p1;

            WriteLine($@"O nome é {p1.Nome}
            e {p2.Nome}");

        }
    }

}
