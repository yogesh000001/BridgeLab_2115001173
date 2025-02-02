using System;

public class BankAccount
{
    
    public string accountNumber;

    protected string accountHolder;

    private double balance;

    public BankAccount(string accNumber, string holder, double initialBalance)
    {
        accountNumber = accNumber;
        accountHolder = holder;
        balance = initialBalance;
    }

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine($"Deposited: ${amount}. New Balance: ${balance}");
        }
        else
        {
            Console.WriteLine("Invalid deposit amount.");
        }
    }

    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
            Console.WriteLine($"Withdrawn: ${amount}. Remaining Balance: ${balance}");
        }
        else
        {
            Console.WriteLine("Invalid withdrawal amount or insufficient balance.");
        }
    }

    public double GetBalance()
    {
        return balance;
    }

    public void DisplayAccountDetails()
    {
        Console.WriteLine("Account Number: " + accountNumber);
        Console.WriteLine("Account Holder: " + accountHolder);
        Console.WriteLine("Balance: $" + balance);
        Console.WriteLine();
    }
}

public class SavingsAccount : BankAccount
{
    public double interestRate; 

    public SavingsAccount(string accNumber, string holder, double initialBalance, double rate)
        : base(accNumber, holder, initialBalance)
    {
        interestRate = rate;
    }

    public void DisplaySavingsDetails()
    {
        Console.WriteLine("Savings Account Details:");
        Console.WriteLine("Account Number: " + accountNumber); 
        Console.WriteLine("Account Holder: " + accountHolder); 
        Console.WriteLine("Interest Rate: " + interestRate + "%");
        Console.WriteLine("Balance (Accessed via GetBalance method): $" + GetBalance());
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        BankAccount account1 = new BankAccount("123456789", "Alice Johnson", 5000);
        account1.DisplayAccountDetails();

        account1.Deposit(1000);
        account1.Withdraw(1500);
        Console.WriteLine("Final Balance: $" + account1.GetBalance());
        Console.WriteLine();

        SavingsAccount savings1 = new SavingsAccount("987654321", "Bob Smith", 8000, 3.5);
        savings1.DisplaySavingsDetails();
    }
}
