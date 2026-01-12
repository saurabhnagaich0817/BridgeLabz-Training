public abstract class LoanApplication : IApprovable
{
    protected Applicant applicant;
    protected int term;
    protected double interestRate;
    private bool loanStatus;

    public LoanApplication(Applicant applicant, int term, double interestRate)
    {
        this.applicant = applicant;
        this.term = term;
        this.interestRate = interestRate;
        loanStatus = false;
    }

    protected bool CheckEligibility(int minScore, double minIncome)
    {
        if (applicant.GetCreditScore() >= minScore &&
            applicant.GetIncome() >= minIncome)
        {
            loanStatus = true;
        }
        return loanStatus;
    }

    public abstract bool ApproveLoan();
    public abstract double CalculateEMI();
}
