using System;
class PositveNegateZero
{
  static void Main()
    {   
      // taking number as input from user
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        // check that the number is positive,negative or zero
        if (number > 0)
            Console.WriteLine("Positive");
        else if (number < 0)
            Console.WriteLine("Negative");
        else
            Console.WriteLine("Zero");  

    }
}
