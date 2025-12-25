using System;

class LeapYear
{
  static bool IsLeapYear(int year)
    {
        if (year < 1582) return false;
        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    }

    static void Main()
    {
        Console.Write("Enter year: ");
        int year = Convert.ToInt32(Console.ReadLine());
// checking leap year
        Console.WriteLine(IsLeapYear(year) ? "Leap Year" : "Not a Leap Year");
    }
}
