using System;

namespace CadastroDeAluno {
    public class FuncoesSimples {

            public void Cabecalho(){
                Console.WriteLine(" ");
                Console.WriteLine("----------------------------");
                Console.WriteLine("     CADASTRO DE ALUNO      ");
                Console.WriteLine("----------------------------");
                Console.WriteLine(" ");
            }

            public void Opcao(){
                Console.WriteLine("Escolha a opção desejada: ");
                Console.WriteLine(" ");
                Console.WriteLine("[1] - Cadastrar novo aluno");
                Console.WriteLine("[2] - Listar alunos cadastrados");
                Console.WriteLine("[3] - Exibir média dos alunos");
                Console.WriteLine("[0] - Sair");
                Console.WriteLine(" ");
            }
        }
    
}