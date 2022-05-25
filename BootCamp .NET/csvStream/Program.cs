using static System.Console;

var path = Path.Combine(Environment.CurrentDirectory, "pastaDoArquivo", "arquivoTeste.csv");

if (File.Exists(path)){
    using var sr = new StreamReader(path);
    var cabecalho = sr.ReadLine()?.Split(',');

    while(true){

        var registro = sr.ReadLine()?.Split(',');
        if(registro == null) break;

        if(cabecalho.Length != registro.Length){
            
            WriteLine("Arquivo fora do padrão !");
            break;
        }

        for (int i = 0; i < registro.Length; i++){

            WriteLine($"{cabecalho?[i]}: {registro[i]}");

        }

        WriteLine("-----------");
    }
} else {
    WriteLine($"o {path} não existe !");
}

WriteLine("Pressione {ENTER} para finalizar");
ReadLine();

