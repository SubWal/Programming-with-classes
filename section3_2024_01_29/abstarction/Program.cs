using System;

// Abstract class
public abstract class Account
{
    public required string AccountNumber { get; set; }
    public double Balance { get; set; }

    // Abstract method
    public abstract void Withdraw(double amount);

    
    public void Deposit(double amount)
    {
        Balance += amount;
        Console.WriteLine($"Deposited {amount:C}. Current balance: {Balance:C}");
    }
}


public class SavingsAccount : Account
{
    // Implementing abstract method
    public override void Withdraw(double amount)
    {
        if (amount > Balance)
            Console.WriteLine("Insufficient funds.");
        else
        {
            Balance -= amount;
            Console.WriteLine($"Withdrawn {amount:C}. Current balance: {Balance:C}");
        }
    }
}


public class CheckingAccount : Account
{
    // Implementing abstract method
    public override void Withdraw(double amount)
    {
        if (amount > Balance)
            Console.WriteLine("Insufficient funds.");
        else
        {
            Balance -= amount;
            Console.WriteLine($"Withdrawn {amount:C}. Current balance: {Balance:C}");
        }
    }
}

class Program
{
    static void Main()
    {
        // Using abstraction
        Account savingsAccount = new SavingsAccount { AccountNumber = "acc1", Balance = 1000 };
        Account checkingAccount = new CheckingAccount { AccountNumber = "acc2", Balance = 2000 };

        savingsAccount.Deposit(500);
        savingsAccount.Withdraw(200);

        checkingAccount.Deposit(1000);
        checkingAccount.Withdraw(250);
    }
}
