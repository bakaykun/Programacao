
using System.IO;
using static System.Console;

WriteLine("Digite o nome do Arquivo");
var nome = ReadLine();
var path = Path.Combine(Environment.CurrentDirectory, $"{nome}.txt");

cirarArquivo(path);

static void cirarArquivo(string path){
    using var sw = File.CreateText(path);
    for(int i = 0; i< 5; i++){
        sw.WriteLine("Linha " + i);
    }
}

