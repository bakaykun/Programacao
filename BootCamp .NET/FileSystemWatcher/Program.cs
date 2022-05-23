//CRIANDO A VARIÁVEL DO DIRETÓRIO

var path = @"C:\Users\Bakay\Documents\Programação\Programacao\BootCamp .NET\Diretorio\globo";
using var fileSystemWatcher = new FileSystemWatcher(path);

//CHAMANDO OS MÉTODOS
fileSystemWatcher.Created += OnCreated;
fileSystemWatcher.Deleted += OnDeleted;
fileSystemWatcher.Renamed += OnRenamed;

//HABILITANDO A FUNÇÃO PARA PATASTAS E SUBPASTAS 
fileSystemWatcher.EnableRaisingEvents = true;
fileSystemWatcher.IncludeSubdirectories = true;

//INFORMANDO O USUÁRIO SOBRE O QUE ESTÁ ACONTECENDO
System.Console.WriteLine("O sistema está monitoriando o diretório");
System.Console.WriteLine("Pressione {ENTER} para finalizar");
System.Console.ReadLine();

//CRIAÇÃO DOS METODOS DE VERIFICAÇÃO DAS PASTAS
void OnCreated(object sender, FileSystemEventArgs e){
    System.Console.WriteLine($"Foi Criado a pasta {e.Name}");
}

void OnDeleted(object sender, FileSystemEventArgs e){
    System.Console.WriteLine($"Foi Deletado a pasta {e.Name}");
}

void OnRenamed(object sender, FileSystemEventArgs e){
    System.Console.WriteLine($"Foi Renomeado a pasta {e.Name}");
}
