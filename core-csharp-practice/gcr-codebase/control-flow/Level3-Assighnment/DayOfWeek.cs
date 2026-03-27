using System;
class DayOfWeek
{
    static void Main(string[] args)
    {    
      // reading input from command line arguments
        int m =int.Parse(args[0]); // month
        int d =int.Parse(args[1]); // day
        int y =int.Parse(args[2]); // year
    // Calculating day of week using Zeller's Congruence
        int y0 = y - (14 - m) / 12;
        int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
        int m0 = m + 12 * ((14 - m) / 12) - 2;
        int d0 = (d + x + (31 * m0) / 12) % 7;

        // Output the day of the week
        Console.WriteLine("Day of week = " + d0);
    }
}
