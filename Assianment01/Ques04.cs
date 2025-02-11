using System;
using System.Collections.Generic;

abstract class BankAccount
{
    private string accountNumber;
    private string holderName;
    protected double balance;

    public string AccountNumber { get { return accountNumber; } }
    public string HolderName { get { return holderName; } }
    public double Balance { get { return balance; } }

    public BankAccount(string accountNumber, string holderName, double balance)
    {
        this.accountNumber = accountNumber;
        this.holderName = holderName;
        this.balance = balance;
    }

    public void Deposit(double amount)
    {
        balance += amount;
    }

    public void Withdraw(double amount)
    {
        if (amount <= balance)
        {
            balance -= amount;
        }
        else
        {
            Console.WriteLine("Insufficient balance.");
        }
    }

    public abstract double CalculateInterest();

    public virtual void ShowDetails()
    {
        Console.WriteLine("Account Number: " + accountNumber);
        Console.WriteLine("Holder Name: " + holderName);
        Console.WriteLine("Balance: " + balance);
    }
}

interface ILoanable
{
    void ApplyForLoan(double amount);
    double CalculateLoanEligibility();
}

class SavingsAccount : BankAccount, ILoanable
{
    private double interestRate = 0.04;
    private double loanLimit = 50000;

    public SavingsAccount(string accountNumber, string holderName, double balance) : base(accountNumber, holderName, balance) { }

    public override double CalculateInterest()
    {
        return balance * interestRate;
    }

    public void ApplyForLoan(double amount)
    {
        if (amount <= loanLimit)
        {
            Console.WriteLine("Loan Approved.");
        }
        else
        {
            Console.WriteLine("Loan Exceeds Limit.");
        }
    }

    public double CalculateLoanEligibility()
    {
        return loanLimit;
    }

    public override void ShowDetails()
    {
        base.ShowDetails();
        Console.WriteLine("Interest Earned: " + CalculateInterest());
        Console.WriteLine("Loan Eligibility: " + CalculateLoanEligibility());
    }
}

class CurrentAccount : BankAccount
{
    private double interestRate = 0.02;

    public CurrentAccount(string accountNumber, string holderName, double balance) : base(accountNumber, holderName, balance) { }

    public override double CalculateInterest()
    {
        return balance * interestRate;
    }

    public override void ShowDetails()
    {
        base.ShowDetails();
        Console.WriteLine("Interest Earned: " + CalculateInterest());
    }
}

class Bank
{
    static void Main()
    {
        List<BankAccount> accounts = new List<BankAccount>
        {
            new SavingsAccount("S123", "Alice", 100000),
            new CurrentAccount("C456", "Bob", 50000)
        };

        foreach (var acc in accounts)
        {
            acc.ShowDetails();
        }

        SavingsAccount sa = new SavingsAccount("S789", "Charlie", 70000);
        sa.ApplyForLoan(30000);
        sa.ApplyForLoan(60000);
    }
}
