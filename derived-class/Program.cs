// See https://aka.ms/new-console-template for more information

namespace BankAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SavingsAccount savingAcc = new SavingsAccount(122446789, 500);
            savingAcc.Deposit(100);
            savingAcc.Withdraw(50);

            CheckingAccount checkingAcc = new CheckingAccount(1020304050, 1000);
            checkingAcc.Deposit(1000);
            checkingAcc.Withdraw(500);

            CheckingAccount ca1 = new CheckingAccount(10156, 10000);
            ca1.Deposit(10);
        }
    }

    abstract class BankAccount
    {
        public long AccountNumber;
        public double Balance;
        public abstract void Deposit(double amount);
        public abstract void Withdraw(double amount);
    }

    class SavingsAccount : BankAccount
    {
        double interestRate;

        public SavingsAccount(long AccountNumber, double Balance)
        {
            this.AccountNumber = AccountNumber;
            this.Balance = Balance;
        }

        override
        public void Deposit(double amount)
        {
            this.Balance += amount;
            Console.WriteLine($"{amount}Rs was deposited to your account number {this.AccountNumber}, your current balance is {this.Balance}");
        }

        override
        public void Withdraw(double amount)
        {
            this.Balance -= amount;
            Console.WriteLine($"{amount}Rs was withdrew from your account number {this.AccountNumber}, your current balance is {this.Balance}");
        }
    }

    class CheckingAccount : BankAccount
    {
        double overdraftLimit;

        public CheckingAccount(long AccountNumber, double Balance)
        {
            this.AccountNumber = AccountNumber;
            this.Balance = Balance;
        }

        override
        public void Deposit(double amount)
        {
            this.Balance += amount;
            Console.WriteLine($"{amount}Rs was deposited to your account number {this.AccountNumber}, your current balance is {this.Balance}");
        }

        override
        public void Withdraw(double amount)
        {
            this.Balance -= amount;
            Console.WriteLine($"{amount}Rs was withdrew from your account number {this.AccountNumber}, your current balance is {this.Balance}");
        }

    }
}