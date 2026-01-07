class FullTimeEmployee : Employee
{
    public FullTimeEmployee(int id, string name, double salary)
        : base(id, name, salary)
    {
    }

    public override double CalculateSalary()
    {
        return baseSalary;
    }
}
