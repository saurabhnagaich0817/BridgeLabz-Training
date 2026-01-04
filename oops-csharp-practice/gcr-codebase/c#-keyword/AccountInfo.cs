using System;

class AccountInfo
{
    // Static members
    public static string bankTitle = "HDFC";
    private static int accountCount = 0;

    // Readonly instance member
    public readonly int accNumber;

    // Instance member
    public string holderName;

    // Constructor
    public AccountInfo(int number, string name)
    {
        this.accNumber = number;      // using this keyword
        this.holderName = name;
        accountCount++;
    }

    // Static method
    public static void ShowAccountCount()
    {
        Console.WriteLine("Total Accounts Created: " + accountCount);
    }

    // Instance method using 'is' operator
    public void ShowDetails(object data)
    {
        if (data is AccountInfo)
        {
            Console.WriteLine("Bank Name   : " + bankTitle);
            Console.WriteLine("Account No  : " + accNumber);
            Console.WriteLine("Holder Name : " + holderName);
        }
    }
}

class BankingSystem
{
    static void Main()
    {
        AccountInfo a1 = new AccountInfo(101, "Vansh");
        AccountInfo a2 = new AccountInfo(102, "Hemant");

        a1.ShowDetails(a1);
        Console.WriteLine();
        a2.ShowDetails(a2);

        AccountInfo.ShowAccountCount();
    }
}
