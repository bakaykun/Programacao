using System;
using CadastroDeAluno;

namespace CadastroDeAluno{
    class Program{
        static void Main(string[] args) {

            var exibir = new FuncoesSimples(); 
            Aluno[] alunos = new Aluno[5];
            var indiceAluno = 0;
            int escolha;

            exibir.Cabecalho();

            exibir.Opcao();
            escolha = Console.ReadLine();

            while(escolha  != "X") {
                
                switch (escolha){
                    case "1":
                        //cadastro do aluno
                        Console.WriteLine("Insira o Nome do Aluno: ");
                        var aluno = new Aluno();
                        aluno.GetNome(Console.ReadLine());

                        Console.WriteLine(" ");

                        Console.WriteLine("Insira a Nota do Aluno: ");
                        if(decimal.TryParse(Console.ReadLine(), out decimal nota)){
                            aluno.GetNota(nota);

                        }else {
                            throw new ArgumentException("O Valor da nota deve ser decimal");
                        };

                        alunos[indiceAluno] = aluno;
                        indiceAluno++;

                        Console.WriteLine(" ");
                        Console.Read();

                        break;

                    case "2":
                        //listagem do aluno
                        foreach (var nomeAluno in alunos){
                            Console.WriteLine($"ALUNO:{nomeAluno.Nome} | NOTA: {nomeAluno.Nota}");
                        }
                        Console.Read();
                        break;

                    case "3":
                        //média do aluno
                        Console.Read();
                        break;

                    default:
                        Console.Read();
                        System.Console.WriteLine("Você Escolheu Sair !");
                        break;
                }

                exibir.Opcao();
                escolha = Console.ReadLine();
            }
            
            


        }
    }
}
