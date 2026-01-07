// Savings Account
public class SavingsAccount : BankAccount, ILoanable
{
    public SavingsAccount(string accNum, string name, double initialBalance)
        : base(accNum, name, initialBalance) { }

    // Interest: 4% of current balance
    public override double CalculateInterest()
    {
        return Balance * 0.04;
    }

    // Loanable methods
    public void ApplyForLoan(double loanAmount)
    {
        Console.WriteLine($"Savings Account Loan Requested: {loanAmount}");
    }

    public double CalculateLoanEligibility()
    {
        return Balance * 2; // Can borrow up to 2x balance
    }
}

// Current Account
public class CurrentAccount : BankAccount, ILoanable
{
    public CurrentAccount(string accNum, string name, double initialBalance)
        : base(accNum, name, initialBalance) { }

    // Interest: 1% of current balance
    public override double CalculateInterest()
    {
        return Balance * 0.01;
    }
    // Loanable methods
public void ApplyForLoan(double loanAmount)
    {
        Console.WriteLine($"Current Account Loan Requested: {loanAmount}");
    }

    public double CalculateLoanEligibility()
    {
        return Balance * 1.5; // Can borrow up to 1.5x balance
    }
}
