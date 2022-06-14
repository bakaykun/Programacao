using ExemploConstrutores.models;
using static System.Console;

Pessoa p1 = new Pessoa("Kelvin", "Santos");

p1.Apresentar();
WriteLine(" ");

//a mesma instancia para todos os chamados
Log log = Log.GetInstance();

log.MyPropertyLog = 2500;
WriteLine(log.MyPropertyLog);

Log log2 = Log.GetInstance();

WriteLine(log2.MyPropertyLog);

WriteLine(" ");

// instancia do aluno usando Herança

Aluno aluno1 = new Aluno ("Maria", "Santos", "Matemática");
aluno1.Apresentar();
aluno1.ShowDisc();
WriteLine(" ");