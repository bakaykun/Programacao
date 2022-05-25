var textReader = "Acorda Pedrinho que hoje tem campeonato.\n\n" + 
                "Hoje tem campeonato.\n\n" + "Vem dançar comigo";

System.Console.WriteLine($"Texto Original: " + textReader);

string linha, paragrafo = null;
var sr = new StringReader(textReader);

while(true){

    linha = sr.ReadLine();

    if ( linha != null) {
        paragrafo += linha + " ";
    }
    else {
        paragrafo += "\n";
        break;
    }
}

System.Console.WriteLine("TEXTO MODIFICADO: " + paragrafo);

//Lendo o texto na forma decimal

int caractereLido;
char caractereConvertido;

var sw = new StringWriter();
sr = new StringReader(paragrafo);

while(true) {

    caractereLido = sr.Read(); 
    if(caractereLido == -1) break;

    caractereConvertido = Convert.ToChar(caractereLido);

    if(caractereConvertido == '.'){
        sw.Write("\n\n");

        sr.Read();
        sr.Read();

    }else {
        sw.Write(caractereConvertido);
    }

    
}

System.Console.WriteLine($"TEXTO COM TABELA ASCII:  {sw.ToString()}");