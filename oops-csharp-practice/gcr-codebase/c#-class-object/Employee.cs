using System;

// Employee class
class Employee
{
    // Data members
    public string name;
    public int id;
    public double salary;
    public void DisplayDetails()
    {
        Console.WriteLine("Employee ID    : " + id);
        Console.WriteLine("Employee Name  : " + name);
        Console.WriteLine("Employee Salary: " + salary);
    }
}

// Main class
class Program
{
    static void Main()
    {
        // Creating object of Employee class
        Employee emp = new Employee();

        // Assigning values
        emp.id = 101;
        emp.name = "Saurabh";
        emp.salary = 45000;

        // Displaying employee details
        emp.DisplayDetails();
    }
}
