using System;

class LYP1
{
    static void Main()
    {
        Console.Write("Enter yr: ");
        int yr = int.Parse(Console.ReadLine());
      // Gregorian calendar condition
        if (yr >= 1582)
        {
            if (yr % 400 == 0)
                Console.WriteLine("Leap yr");
            else if (yr % 100 == 0)
                Console.WriteLine("Not a Leap yr");
            else if (yr % 4 == 0)
                Console.WriteLine("Leap yr");
            else
                Console.WriteLine("Not a Leap yr");
        }
        else
        {
            Console.WriteLine("yr must be 1582 or later");
        }
    }
}
