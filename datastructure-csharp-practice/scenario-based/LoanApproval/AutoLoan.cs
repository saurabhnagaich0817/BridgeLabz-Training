public class AutoLoan : LoanApplication
{
    public AutoLoan(Applicant applicant, int term)
        : base(applicant, term, 0.10) { }

    public override bool ApproveLoan()
    {
        return CheckEligibility(650, 20000);
    }

    public override double CalculateEMI()
    {
        double P = applicant.GetLoanAmount();
        double R = interestRate / 12;
        int N = term;

        return (P * R * Math.Pow(1 + R, N)) /(Math.Pow(1 + R, N) - 1);
    }
}
