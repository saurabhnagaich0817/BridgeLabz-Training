using System;

namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Employee Wage Computation Program");

            EmployeeMenu menu = new EmployeeMenu();
            menu.ShowMenu();
        }
    }
}
