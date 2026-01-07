using System;


public abstract class BankAccount
{
    private string accountNumber;
    private string holderName;
    private double balance;
     public string AccountNumber { get { return accountNumber; } set { accountNumber = value; } }
    public string HolderName { get { return holderName; } set { holderName = value; } }
    public double Balance 
    { 
        get { return balance; } 
        protected set 
        {
            if (value >= 0) balance = value;
            else Console.WriteLine("Balance cannot be negative!");
        } 
    }

    public BankAccount(string accNum, string name, double initialBalance)
    {
        AccountNumber = accNum;
        HolderName = name;
        Balance = initialBalance;
    }

    // Deposit money
    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            Console.WriteLine($"{amount} deposited. New balance: {Balance}");
        }
        else
        {
            Console.WriteLine("Deposit amount must be positive.");
        }
    }

    // Withdraw money
    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= Balance)
        {
            Balance -= amount;
            Console.WriteLine($"{amount} withdrawn. Remaining balance: {Balance}");
        }
        else
        {
            Console.WriteLine("Insufficient balance or invalid amount.");
        }
    }

    // Abstract method to calculate interest
    public abstract double CalculateInterest();
}

// Interface for loanable accounts
public interface ILoanable
{
    void ApplyForLoan(double loanAmount);
    double CalculateLoanEligibility();
}
