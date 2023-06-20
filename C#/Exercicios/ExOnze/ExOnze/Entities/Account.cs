using ExOnze.Entities.Exception;
namespace ExOnze.Entities
{
    public class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account() {}

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposito(double quantidade)
        {
            Balance += quantidade;
        }
        
        public void Saque(double quantidade)
        {
            if(quantidade > Balance)
            {
                throw new DomainException("Puxa Vida marreco, sem saldo");
            }
            if(quantidade > WithdrawLimit)
            {
                throw new DomainException("Valor do saque maior que o valor de limite de conta Pae!");
            }

            Balance -= quantidade;
            System.Console.WriteLine("Saldo: " + Balance);
        }
    }
}