using System;
class Voting
{
  static void Main()
  {   
    // taking age as input from user
    Console.Write("Enter the age:");
    int age = int.Parse(Console.ReadLine());
    // checking voting eligibility
    if (age >= 18)
    // 
        Console.WriteLine($"The person's age is {age} and can vote.");
    else
        Console.WriteLine($"The person's age is {age} and cannot vote.");
  }
}