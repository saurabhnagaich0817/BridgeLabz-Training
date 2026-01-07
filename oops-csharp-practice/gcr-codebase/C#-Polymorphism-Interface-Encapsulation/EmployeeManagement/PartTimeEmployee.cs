class PartTimeEmployee : Employee
{
    private int hoursWorked;

    public PartTimeEmployee(int id, string name, double hourlyRate, int hours)
        : base(id, name, hourlyRate)
    {
        hoursWorked = hours;
    }

    public override double CalculateSalary()
    {
        return baseSalary * hoursWorked;
    }
}
