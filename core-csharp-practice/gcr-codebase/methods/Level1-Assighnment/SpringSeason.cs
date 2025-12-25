using System;

class SpringSeason
{
  static bool Spring(int month, int day)
    {
        if((month == 3 && day >= 20) ||(month == 4) ||(month == 5) ||(month == 6 && day <= 20))
            return true;

        return false;
    }

    static void Main(string[] args)
    {
      // taking month and day as input from user
        int month = int.Parse(args[0]);
        int day = int.Parse(args[1]);

        if(Spring(month, day))
            Console.WriteLine("Its a Spring Season");
        else
            Console.WriteLine("Not a Spring Season");
    }
}
