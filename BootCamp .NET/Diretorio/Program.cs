//Chamada das funções
criarDiretoriosDoMundo();
criarArquivo();

//Movendo o arquivo
var origem = Path.Combine(Environment.CurrentDirectory, "globo", "América do Sul", "Brasil.ext");
var destino = Path.Combine(Environment.CurrentDirectory, "globo", "América do Sul", "Brasil", "Brasil.ext");

moverArquivo(origem, destino);

static void moverArquivo(string pathOrigem, string pathDestino){

    if(!File.Exists(pathOrigem)) {
        Console.WriteLine("Arquivo de Origem Não Existe");
        return;
    }

    if(File.Exists(pathDestino)){
        Console.WriteLine("Arquivo de destijo já existe");
        return;
    }
    
    File.Move(pathOrigem, pathDestino);

    
}

static void criarArquivo(){
    var path = Path.Combine(Environment.CurrentDirectory, "Brasil.ext");

    if(!File.Exists(path)){
        using var sw = File.CreateText(path);
        sw.WriteLine("Populacao: 213.000.123");
        sw.WriteLine("IDH: 0.95");
        sw.WriteLine("Dados Atualizados em 21/05/2018");
    }

}

static void criarDiretoriosDoMundo(){
    //criando o diretório central
    var path = Path.Combine(Environment.CurrentDirectory, "globo");
    
    if(!Directory.Exists(path)){

        var dirNacao = Directory.CreateDirectory(path);
        //Criando os sub diretórios 
        var dirAmNorte = dirNacao.CreateSubdirectory("América do Norte");
        var dirAmSul = dirNacao.CreateSubdirectory("América do SUl");
        var dirAmCentral = dirNacao.CreateSubdirectory("América Central");

        //criando o sub diretório do sub diretório
        //AMérica do norte
        dirAmNorte.CreateSubdirectory("México");
        dirAmNorte.CreateSubdirectory("Canada");
        dirAmNorte.CreateSubdirectory("Alasca");

        //América do Sul
        dirAmSul.CreateSubdirectory("Brasil");
        dirAmSul.CreateSubdirectory("Chile");
        dirAmSul.CreateSubdirectory("Bolivia");

        //América CENTRAL
        dirAmCentral.CreateSubdirectory("Costa Rica");
        dirAmCentral.CreateSubdirectory("Panamá");
        dirAmCentral.CreateSubdirectory("Honduras");

    } else {
        var newPath = Path.Combine(Environment.CurrentDirectory, "Existia e eu fui criado");
        var dirExecucao = Directory.CreateDirectory(newPath);

        dirExecucao.CreateSubdirectory("De novo");
    }


}



