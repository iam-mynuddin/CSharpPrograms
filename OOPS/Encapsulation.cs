using System;
namespace OopsConcept.Encapsulation
{
    
class BankAccount
{
    private string accountNumber;
    private double balance;

    public BankAccount(string accountNumber, double initialBalance)
    {
        this.accountNumber = accountNumber;
        this.balance = initialBalance;
    }

    public string AccountNumber
    {
        get { return accountNumber; }
        set { accountNumber = value; }
    }

    public double Balance
    {
        get { return balance; }
        private set { balance = value; }
    }

    public void Deposit(double amount)
    {
        if (amount > 0)
            balance += amount;
        else
            Console.WriteLine("Invalid amount for deposit.");
    }

    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= balance)
            balance -= amount;
        else
            Console.WriteLine("Invalid amount for withdrawal.");
    }
}

class Program
{
    //static void Main()
    //{
    //    BankAccount account = new BankAccount("123456789", 1000);
    //    Console.WriteLine("Account Number: " + account.AccountNumber);
    //    Console.WriteLine("Current Balance: " + account.Balance);
    //    account.Deposit(500);
    //    Console.WriteLine("New Balance after deposit: " + account.Balance);
    //    account.Withdraw(200);
    //    Console.WriteLine("New Balance after withdrawal: " + account.Balance);
    //}
}

}