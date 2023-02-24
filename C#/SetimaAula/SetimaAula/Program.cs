using static System.Console;

namespace SetimaAula{

    class Program {

        static void Main(string[] args){

            ContaBancaria conta01 = new ContaBancaria("Defaut", 111);

            Write("Insira seu nome: ");
            conta01.Nome = ReadLine();
            Write("Insira sua conta: ");
            conta01.NumContaBancaria = int.Parse(ReadLine());
            Write("Deseja fazer depósito inicial?(s/n): ");
            string v = ReadLine();

            if (v == "s" || v == "S"){
                WriteLine("Insira o Valor que deseja Depositar");
                conta01.Saldo = double.Parse(ReadLine());
            }

            Write(conta01 + "\n");

            Write("Entre com o valor para depósito :");
            double dep = double.Parse(ReadLine());

            conta01.Deposito(dep);

            Write(conta01 + "\n");

            Write("Entre com o valor para saque :");
            double saq = double.Parse(ReadLine());

            conta01.Saque(saq);

            Write(conta01);
            Write("\n");
            

        }

    }

}
