using System;

public class LoanUtility
{
    public Applicant CreateApplicant(
        string name, int creditScore, double income, double amount)
    {
        return new Applicant(name, creditScore, income, amount);
    }

    public IApprovable CreateLoan(
        int choice, Applicant applicant, int term)
    {
        if (choice == 1)
            return new HomeLoan(applicant, term);
        else if (choice == 2)
            return new AutoLoan(applicant, term);
        else
            return null;
    }

    public void ProcessLoan(IApprovable loan)
    {
        if (loan == null)
        {
            Console.WriteLine("Invalid Loan Selection");
            return;
        }

        if (loan.ApproveLoan())
        {
            Console.WriteLine("Loan Approved ");
            Console.WriteLine("Monthly EMI: " +
                Math.Round(loan.CalculateEMI(), 2));
        }
        else
        {
            Console.WriteLine("Loan Rejected ");
        }
    }
}
