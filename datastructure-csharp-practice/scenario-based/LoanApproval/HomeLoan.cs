public class HomeLoan : LoanApplication
{
    public HomeLoan(Applicant applicant, int term)
        : base(applicant, term, 0.08) { }

    public override bool ApproveLoan()
    {
        return CheckEligibility(700, 30000);
    }

    public override double CalculateEMI()
    {
        double P = applicant.GetLoanAmount();
        double R = interestRate / 12;
        int N = term;

        return (P * R * Math.Pow(1 + R, N)) /(Math.Pow(1 + R, N) - 1);
    }
}
