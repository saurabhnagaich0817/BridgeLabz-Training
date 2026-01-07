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
}