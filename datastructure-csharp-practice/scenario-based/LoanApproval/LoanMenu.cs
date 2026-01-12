using System;

public class LoanMenu
{
    private LoanUtility utility = new LoanUtility();

    public void ShowMenu()
    {
        Console.Write("Enter Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Credit Score: ");
        int score = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Monthly Income: ");
        double income = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Loan Amount: ");
        double amount = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Loan Term (months): ");
        int term = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("1. Home Loan");
        Console.WriteLine("2. Auto Loan");
        int choice = Convert.ToInt32(Console.ReadLine());

        Applicant applicant =
            utility.CreateApplicant(name, score, income, amount);

        IApprovable loan =
            utility.CreateLoan(choice, applicant, term);

        utility.ProcessLoan(loan);
    }
}
