using System;
class DivisibleBy5
{
  static void Main()
    {   
      // taking input from user 
        Console.Write("Enter a num1: ");
        int num1 = int.Parse(Console.ReadLine());
        // checking divisibility
        bool res = (num1 % 5 == 0);
        Console.WriteLine($"Is the num1 {num1} divisible by 5? {res}");
    }
}
