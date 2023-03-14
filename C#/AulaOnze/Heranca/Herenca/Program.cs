using static System.Console;
using Herenca.Entities;
namespace Heranca
{
    class Program 
    {
        static void Main()
        {
            Account acc = new Account(1001, "Carlos0", 00.00);

            BussinesAccount bacc = new BussinesAccount(1002, "Maria", 0.50, 980.00);

            //To make a Upcasting

            Account acc1 = bacc;
            Account acc2 = new BussinesAccount(1003, "Fabricio", 520.00, 200.00);
            Account acc3 = new SavingsAccount(1004, "Kelvin", 5890.00, 0.6);
            SavingsAccount acc4 = new SavingsAccount(1005, "Patrick", 9860.00, 0.5);
            acc4.UpdateBalance();
            WriteLine(acc4);
            WriteLine(" ");

            //To make DownCast
            BussinesAccount acc5 = (BussinesAccount)acc2;
            acc5.Loan(100.5);
            WriteLine(acc5);
            WriteLine(" ");
            
            //Warning, this cast is not compatible
            //BussinesAccount acc6 = (BussinesAccount)acc3;

            //How convert a subclss for subclass, remenber! Downcast is insegure convertion
            //make the use only testing convertion whit operator is 

            //I can make a downcast with reserved word "as", reserved "is" only comparation

            if (acc3 is BussinesAccount)
            {
                BussinesAccount acc6 = (BussinesAccount) acc3;
                acc6.Loan(200.00);
                Write("Loan sucessfull !   ");
                WriteLine(acc6);
            }

            if (acc3 is SavingsAccount)
            {
                SavingsAccount acc6 = (SavingsAccount) acc3;
                acc6.UpdateBalance();
                Write("Update sucessfull !\n\n");
                WriteLine(acc6);
            }

        }
    }
}
