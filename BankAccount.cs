using System;

public class BankAccount
{
    public string AccountNumber { get; }
    public double Balance { get; private set; }
    public string Type { get; }

    public BankAccount(string accountNumber, double initialBalance)
    {
        AccountNumber = accountNumber;
        Balance = initialBalance;
        Type = "Checking";
    }

    public BankAccount(string accountNumber, double initialBalance, string type)
    {
        AccountNumber = accountNumber;
        Balance = initialBalance;
        Type = type;
    }

    public BankAccount(string accountNumber) : this(accountNumber, 0)
    {
    }

    public BankAccount(string accountNumber, string type) : this(accountNumber, 0, type)
    {
    }

    public void Deposit(double amount)
    {
        Balance += amount;
        Console.WriteLine($"${amount:C} deposited into account {AccountNumber}.");
        Console.WriteLine($"New balance: ${Balance:C}");
    }

    public void Withdraw(double amount)
    {
        if (Balance >= amount)
        {
            Balance -= amount;
            Console.WriteLine($"${amount:C} withdrawn from account {AccountNumber}.");
            Console.WriteLine($"New balance: ${Balance:C}");
        }
        else
        {
            Console.WriteLine("Insufficient funds.");
        }
    }
}


class Program
{
    static void Main(string[] args)
    {
        
        BankAccount checkingAccount = new BankAccount("SCI33535", 13000.0,"Savings");
        BankAccount savingAccount = new BankAccount("SCI244233", 2000.0);

        checkingAccount.Deposit(600);
        checkingAccount.Withdraw(100);

        savingAccount.Deposit(300);
        savingAccount.Withdraw(250);
        Console.ReadLine();
    }
}
