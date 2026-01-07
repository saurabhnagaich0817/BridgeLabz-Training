using System;

class Program
{
    static void Main()
    {
        // Polymorphism: Employee reference
        Employee[] employees = new Employee[2];

        employees[0] = new FullTimeEmployee(1, "Rahul", 50000);
        employees[1] = new PartTimeEmployee(2, "Amit", 500, 40);

        employees[0].AssignDepartment("IT");
        employees[1].AssignDepartment("HR");

        foreach (Employee emp in employees)
        {
            emp.DisplayDetails();
        }
    }
}
