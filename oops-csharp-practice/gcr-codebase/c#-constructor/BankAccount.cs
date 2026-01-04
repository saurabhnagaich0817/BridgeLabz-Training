using System;

class BankAccount
{
    // Public member
    public int accNo;

    // Protected member
    protected string holderName;

    // Private member
    private double totalAmount;

    // Setter for balance
    public void Deposit(double amount)
    {
        totalAmount = amount;
    }

    // Getter for balance
    public double CheckBalance()
    {
        return totalAmount;
    }

    // Setter for account holder
    public void AssignHolder(string name)
    {
        holderName = name;
    }
}

class SavingAccount : BankAccount
{
    public void ShowAccountInfo()
    {
        Console.WriteLine("Account No    : " + accNo);
        Console.WriteLine("Holder Name   : " + holderName);
        Console.WriteLine("Available Bal : ₹" + CheckBalance());
    }
}

class BankingApp
{
    static void Main()
    {
        SavingAccount account = new SavingAccount();

        account.accNo = 12345;
        account.AssignHolder("Vansh");
        account.Deposit(50000);

        account.ShowAccountInfo();
    }
}
