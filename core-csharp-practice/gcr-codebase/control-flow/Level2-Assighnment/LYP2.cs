using System;

class LYP2
{
    static void Main()
    {

      // reading year input from user
        Console.Write("Enter yr: ");
        int yr = int.Parse(Console.ReadLine());
// Checking leap year condition
        if (yr >= 1582 && (yr % 400 == 0 || (yr % 4 == 0 && yr % 100 != 0)))
            Console.WriteLine("Leap year");
        else
            Console.WriteLine("Not a Leap Year");
    }
}
