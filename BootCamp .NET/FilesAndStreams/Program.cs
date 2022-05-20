using System.IO;
using static System.Console;

//pegando o nome do arquivo
WriteLine("Digite o nome do Arquivo");
var nome = ReadLine();
//chmando a função de limpar o nome
nome = limparNome(nome);

//colocando o arquivo em uma váriável e setando ele em uma pasta já com a extenção
var path = Path.Combine(Environment.CurrentDirectory, $"{nome}.txt");

//declarando a função de criar arquivo
cirarArquivo(path);

WriteLine("Digite ENTER para finalizar");
ReadLine();

static string limparNome(string nome){
    //captando um caractere invalido e trocando ele por um válido
    foreach (var caractere in Path.GetInvalidFileNameChars()){
         nome = nome.Replace(caractere, '-');
    }
    return nome;
}
static void cirarArquivo(string path){
    try {
        //colocando o texto dentro do aquivo
        using var sw = File.CreateText(path);
        for(int i = 0; i< 5; i++){
            sw.WriteLine("Linha " + i);
        }
    }
    catch {
        //caso o nome não seja válido, exiba a mensagem
        WriteLine("O nome do arquivo está inválido");
    }

}

