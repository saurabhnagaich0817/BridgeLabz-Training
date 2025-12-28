using System;

class DateArithmetic
{
    static void Main()
    {
      // taking date as input from user
        Console.Write("Enter date (yyyy-MM-dd): ");
        DateTime date = DateTime.Parse(Console.ReadLine());
// Performing date arithmetic
        DateTime result = date
                            .AddDays(7)
                            .AddMonths(1)
                            .AddYears(2)
                            .AddDays(-21);   // 3 weeks subtract

        Console.WriteLine("Final Date: " + result.ToShortDateString());
    }
}
