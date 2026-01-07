using System;

class EmployeeWageImpl : IEmployeeWage
{
    private const int WAGE_PER_HOUR = 20;
    private const int FULL_DAY_HOUR = 8;
    private const int PART_TIME_HOUR = 8;
    private const int WORKING_DAYS = 20;
    private const int MAX_HOURS = 100;
    public void CheckAttendance()
    {
        int isPresent = new Random().Next(0, 2);
        if (isPresent == 1)
            Console.WriteLine("Employee is Present");
        else
            Console.WriteLine("Employee is Absent");
    }
    public void CalculateDailyWage()
    {
        int isPresent = new Random().Next(0, 2);

        if (isPresent == 1)
        {
            int dailyWage = WAGE_PER_HOUR * FULL_DAY_HOUR;
            Console.WriteLine("Daily Employee Wage = " + dailyWage);
        }
        else
        {
            Console.WriteLine("Daily Employee Wage = 0");
        }
    }
    public void PartTimeWage()
    {
        int empType = new Random().Next(0, 2);

        if (empType == 1)
        {
            int wage = WAGE_PER_HOUR * PART_TIME_HOUR;
            Console.WriteLine("Part Time Employee Wage = " + wage);
        }
        else
        {
            Console.WriteLine("Employee is Full Time");
        }
    }
    public int GetWorkingHours()
    {
        int empType = new Random().Next(0, 3);

        switch (empType)
        {
            case 1:
                return FULL_DAY_HOUR;
            case 2:
                return PART_TIME_HOUR;
            default:
                return 0;
        }
    }
    public void MonthlyWage()
    {
        int monthlyWage = WORKING_DAYS * FULL_DAY_HOUR * WAGE_PER_HOUR;
        Console.WriteLine("Monthly Employee Wage = " + monthlyWage);
    }
    public void WageTillCondition()
    {
        int totalHours = 0;
        int totalDays = 0;

        while (totalHours < MAX_HOURS && totalDays < WORKING_DAYS)
        {
            totalDays++;
            int hours = GetWorkingHours();
            totalHours += hours;
        }

        int totalWage = totalHours * WAGE_PER_HOUR;
        Console.WriteLine("Total Days Worked = " + totalDays);
        Console.WriteLine("Total Hours Worked = " + totalHours);
        Console.WriteLine("Total Wage = " + totalWage);
    }
}
