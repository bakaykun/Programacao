using System.IO;

var path = Path.Combine(Environment.CurrentDirectory, "Teste.txt");

using var sw = File.CreateText(path);

//sem o usuing;
//isso ainda tá em memória
/*sw.WriteLine("Este é o primeiro arquivo que eu to fazendo dentro de um arquivo");
sw.WriteLine("Este é o primeiro arquivo que eu to fazendo dentro de um arquivo");
sw.WriteLine("Este é o primeiro arquivo que eu to fazendo dentro de um arquivo");

//com o flush vai para o arquivo que queremos
sw.Flush();*/

//com o using, fechando a aplicação de forma forçada e gravando o Flush automático;
sw.WriteLine("Este é o teste para o programa");


