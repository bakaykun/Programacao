namespace Herenca.Entities
{
    public class BussinesAccount : Account
    {
        public double LoanLimit { get; set; }

        public BussinesAccount() 
        {

        }

        public BussinesAccount(int number, string holder, double balance, double loanLimit) 
            : base (number, holder, balance)
        {
            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            if(amount <= LoanLimit){
                Balance += amount - 10.00;
            }
        }

    }
}