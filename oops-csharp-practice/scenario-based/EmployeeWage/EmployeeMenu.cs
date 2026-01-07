using System;

class EmployeeMenu
{
    private IEmployeeWage service = new EmployeeWageImpl();

    public void ShowMenu()
    {
        Console.WriteLine("\n1. Check Attendance");
        Console.WriteLine("2. Daily Wage");
        Console.WriteLine("3. Part Time Wage");
        Console.WriteLine("4. Monthly Wage");
        Console.WriteLine("5. Wage Till Condition");

        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                service.CheckAttendance();
                break;
            case 2:
                service.CalculateDailyWage();
                break;
            case 3:
                service.PartTimeWage();
                break;
            case 4:
                service.MonthlyWage();
                break;
            case 5:
                service.WageTillCondition();
                break;
            default:
                Console.WriteLine("Invalid Choice");
                break;
        }
    }
}
