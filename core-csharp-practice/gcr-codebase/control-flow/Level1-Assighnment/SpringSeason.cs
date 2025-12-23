using System;

class SpringSeason
{
    static void Main()
    {
      // taking month and day as input from user
        Console.Write("Enter month: ");
        int month = int.Parse(Console.ReadLine());
// taking day as input from user
        Console.Write("Enter day: ");
        int day = int.Parse(Console.ReadLine());
// checking for spring season
        if((month == 3 && day >= 20) ||
            month == 4 ||
            month == 5 ||
           (month == 6 && day <= 20))
        {
            Console.WriteLine("Its a Spring Season");
        }
        else
        {
            Console.WriteLine("Not a Spring Season");
        }
    }
}
