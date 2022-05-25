//blibioteca pra usar a funcionalidade
using System.Text;

var stringBuilder = new StringBuilder();

//criando linha dentro do objeto

stringBuilder.AppendLine("A cor da Pedrinho Hoje tem campeonato");
stringBuilder.AppendLine("Asfgdsfgsdfgsdato");
stringBuilder.AppendLine("A fgdfgsdfgsdfgsdfgsdampeonato");
stringBuilder.AppendLine("A cor dfsgsdfgdsfgdsfds ftgdsfg sampeonato");

//fazendo a leitura do objeto

using var stringRader = new StringReader(stringBuilder.ToString());

/*Forma grande
/bufferizando o objeto
var buffer = new char[10];
var posicao = stringRader.Read(buffer);

/recompondo o objeto bufferizado da forma zuada
Console.WriteLine($"{string.Join(" ", buffer)}");

Lendo o objeto na mesma linha:

-> Com um texto grande

var buffer = new char[10];
var tamanho = 0;
do {
    //declarando ele de novo para garantir que ele tá limpo
    buffer = new char[10];
    tamanho = stringRader.Read(buffer);
    Console.Write($"{string.Join("", buffer)}");

}while(tamanho >= buffer.Length);*/

//Forma Enxuta > coisa pequena

do {
    Console.WriteLine(stringRader.ReadLine());
} while (stringRader.Peek() >= 0);


Console.Write("\n");
Console.Write("");
Console.WriteLine("Tecle [ENTER] para continuar");
Console.ReadKey();