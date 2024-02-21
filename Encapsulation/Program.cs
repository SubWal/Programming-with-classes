using System;

public class BankAccount
{
    private string accountNumber;
    private decimal balance;

    public BankAccount(string accountNumber, decimal initialBalance)
    {
        this.accountNumber = accountNumber;
        this.balance = initialBalance;
    }

    public void Deposit(decimal amount)
    {
        // Encapsulated method for depositing money
        balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        // Encapsulated method for withdrawing money
        if (balance >= amount)
        {
            balance -= amount;
        }
        else
        {
            Console.WriteLine("Insufficient funds");
        }
    }

    public decimal GetBalance()
    {
        // Encapsulated method for getting balance
        return balance;
    }
}

class Program
{
    static void Main()
    {
        BankAccount account = new BankAccount("123456789", 1000);
        account.Deposit(500);
        account.Withdraw(200);
        Console.WriteLine(account.GetBalance()); // Output: 1300
    }
}
