using System;

class EmployeeMain
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Employee Wage Computation Program");

        EmployeeMenu menu = new EmployeeMenu();
        menu.ShowMenu();
    }
}
