using static System.Console;

WriteLine("Pressione [ENTER] para finalizar");
ReadLine();

var path = Path.Combine(Environment.CurrentDirectory, "saida");

var pessoas = new List<Pessoa>(){
    new Pessoa(){
        Nome = "Kelvin Patrick Dos Santos",
        Email = "kp@gmail.com",
        Telefone = 1455236212,
        Nascimento =  new DateOnly(year: 1999, month: 11, day: 30)
    },

    new Pessoa(){
        Nome = "Kelvin Patrick Dos Santos",
        Email = "kp@gmail.com",
        Telefone = 1455236212,
        Nascimento =  new DateOnly(year: 1999, month: 11, day: 30)
    },

    new Pessoa(){
        Nome = "Kelvin Patrick Dos Santos",
        Email = "kp@gmail.com",
        Telefone = 1455236212,
        Nascimento =  new DateOnly(year: 1999, month: 11, day: 30)
    }
};

var di = new DirectoryInfo(path);

if (!di.Exists){
    di.Create();
    path = Path.Combine(path, "saida.csv");
}

using var sw = new StreamWriter(path);
sw.WriteLine("nome, email, telefone, nascimento");
foreach (var item in pessoas)
{
    var linha = $"{item.Nome}, {item.Email}, {item.Telefone}, {item.Nascimento}";
    sw.WriteLine(linha);
}

class Pessoa{
    public string Nome { get; set; }
    public string Email { get; set; }
    public int Telefone { get; set; }
    public DateOnly Nascimento { get; set; }

};