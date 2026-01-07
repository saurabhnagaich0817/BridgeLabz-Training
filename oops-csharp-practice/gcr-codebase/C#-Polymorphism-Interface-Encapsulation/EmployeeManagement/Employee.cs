using System;

abstract class Employee : IDepartment
{
    // Encapsulation (private fields)
    private int employeeId;
    private string name;
    protected double baseSalary;
    private string department;

    // Properties (controlled access)
    public int EmployeeId
    {
        get { return employeeId; }
        set { employeeId = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    // Constructor
    public Employee(int id, string name, double baseSalary)
    {
        this.employeeId = id;
        this.name = name;
        this.baseSalary = baseSalary;
    }

    // Abstract method
    public abstract double CalculateSalary();

    // Concrete method
    public void DisplayDetails()
    {
        Console.WriteLine($"ID: {employeeId}");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Department: {department}");
        Console.WriteLine($"Salary: {CalculateSalary()}");
        Console.WriteLine();
    }

    // Interface methods
    public void AssignDepartment(string dept)
    {
        department = dept;
    }

    public string GetDepartmentDetails()
    {
        return department;
    }
}
