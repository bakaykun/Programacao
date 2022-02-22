using System;
using CadastroDeAluno;

namespace CadastroDeAluno{
    class Program{
        static void Main(string[] args) {

            var exibir = new FuncoesSimples(); 
            Aluno[] alunos = new Aluno[5];
            var indiceAluno = 0;
            string escolha;

            exibir.Cabecalho();

            exibir.Opcao();
            escolha = Console.ReadLine();

            while (escolha != "x") {

                switch (escolha){
                    case "1":

                        Console.WriteLine("");
                        Console.WriteLine("Insira o Nome do Aluno: ");

                        var aluno = new Aluno();
                        aluno.Nome = Console.ReadLine();

                        Console.WriteLine(" ");
                        Console.WriteLine("Insira a Nota do Aluno: ");

                        if(decimal.TryParse(Console.ReadLine(), out decimal nota)){
                            aluno.Nota = nota;
                        }else {
                            throw new ArgumentException("O Valor da nota deve ser decimal");
                        }

                        alunos[indiceAluno] = aluno;
                        indiceAluno++;

                        Console.WriteLine("");
                        Console.WriteLine("CADASTRO REALIZADO COM SUCESSO");
                        Console.WriteLine("TECLE ENTER PARA IR AO MENU PRINCIPAL...");
                        Console.WriteLine("");
                        Console.Read();
                        Console.Clear();

                        break;

                    case "2":
                        Console.WriteLine("");
                        foreach (var nomeAluno in alunos){
                            
                            if (!string.IsNullOrEmpty(nomeAluno.Nome)) {
                                Console.WriteLine($"ALUNO: {nomeAluno.Nome} | NOTA: {nomeAluno.Nota}");

                            }
                        }

                        Console.WriteLine("");
                        Console.WriteLine("TECLE ENTER PARA IR AO MENU PRINCIPAL...");
                        Console.Read();

                        break;

                    case "3":
                        
                        decimal notaTotalMedia = 0;
                        int numeroDeAlunos = 0;

                        for (int i = 0; i < alunos.Length; i++){
                            
                            if(!string.IsNullOrEmpty(alunos[i].Nome)){
                                notaTotalMedia+=alunos[i].Nota;
                                numeroDeAlunos++;
                            }
                        }
                        
                        var mediaTotal = notaTotalMedia / numeroDeAlunos;

                        Console.WriteLine("");
                        Console.WriteLine($"A média total é: {mediaTotal}");
                        Console.WriteLine("");
                        Console.WriteLine("TECLE ENTER PARA IR AO MENU PRINCIPAL...");
                        Console.Read();

                        break;

                }
                
                
                Console.Clear();
                exibir.Opcao();
                escolha = Console.ReadLine();
            }
            
            
        }
    }
}
