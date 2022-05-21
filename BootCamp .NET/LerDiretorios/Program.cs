var path = @"C:\Users\Bakay\Documents\Programação\Programacao\BootCamp .NET\FilesAndStreams";
//LerDiretorios(path);
lerArquivos(path);

System.Console.WriteLine("Pressione [ENTER] para continuar");
System.Console.ReadLine();

static void lerArquivos(string path){
    
    var arquivos = Directory.GetFiles(path,"*",SearchOption.AllDirectories);

    foreach(var aqv in arquivos){

        var infoArquivo = new FileInfo(aqv);
    
        System.Console.WriteLine($"Nome: {infoArquivo.Name}");
        System.Console.WriteLine($"Tamanho: {infoArquivo.Length} Kb");
        System.Console.WriteLine($"Ultimo Acesso: {infoArquivo.LastAccessTime} ");
        System.Console.WriteLine($"Pasta: {infoArquivo.DirectoryName}");
        System.Console.WriteLine("");
        System.Console.WriteLine("");


    }
}

static void LerDiretorios(string path){

    if(Directory.Exists(path)){
        var diretorios = Directory.GetDirectories(path,"*", SearchOption.AllDirectories);
        
        foreach(var dir in diretorios){

            var dirInfo = new DirectoryInfo(dir);

            System.Console.WriteLine($"Nome: {dirInfo.Name}");
            System.Console.WriteLine($"Raiz: {dirInfo.Root}");
            if(dirInfo.Parent != null)
                System.Console.WriteLine($"Pai: {dirInfo.Parent.Name}");
            System.Console.WriteLine("========================");


        }

    }else {
        System.Console.WriteLine($"O diretório {path} não existe");
    }

}