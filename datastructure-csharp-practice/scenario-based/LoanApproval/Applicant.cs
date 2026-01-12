public class Applicant
{
    private string name;
    private int creditScore;
    private double income;
    private double loanAmount;

    public Applicant(string name, int creditScore, double income, double loanAmount)
    {
        this.name = name;
        this.creditScore = creditScore;
        this.income = income;
        this.loanAmount = loanAmount;
    }

    public int GetCreditScore() => creditScore;
    public double GetIncome() => income;
    public double GetLoanAmount() => loanAmount;

    public override string ToString()
    {
        return $"Name: {name}, CreditScore: {creditScore}, Income: {income}, LoanAmount: {loanAmount}";
    }
}
