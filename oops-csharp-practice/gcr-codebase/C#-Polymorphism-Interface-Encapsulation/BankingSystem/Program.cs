class Program
{
    static void Main(string[] args)
    {
        // Create accounts
        BankAccount acc1 = new SavingsAccount("S001", "Alice", 50000);
        BankAccount acc2 = new CurrentAccount("C001", "Bob", 30000);

        // Array of accounts
        BankAccount[] accounts = { acc1, acc2 };

        Console.WriteLine("----- Banking System Details -----\n");

        foreach (var acc in accounts)
        {
            Console.WriteLine($"Account: {acc.AccountNumber}, Holder: {acc.HolderName}, Balance: {acc.Balance}");
            Console.WriteLine($"Interest for this account: {acc.CalculateInterest()}");

            // Check if account supports loan
            if (acc is ILoanable loanableAcc)
            {
                Console.WriteLine($"Loan Eligibility: {loanableAcc.CalculateLoanEligibility()}");
                loanableAcc.ApplyForLoan(10000); 
            }

            Console.WriteLine();
        }

        // Test Deposit & Withdraw
        acc1.Deposit(5000);
        acc2.Withdraw(2000);
    }
}
