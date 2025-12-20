using System;
class Calculator
{

  
  static void Main()
    {
        //  taking input from user and declaring variables
        double num1, num2;

        Console.Write("Enter first number: ");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number: ");
        num2 = Convert.ToDouble(Console.ReadLine());
        // an arithmetic operations is 
        double add = num1 + num2;
        double sub = num1 - num2;
        double mul = num1 * num2;
        double div = num1 / num2;
        // printing the result
Console.WriteLine( "The addition, subtraction, multiplication and division value of 2 numbers " +num1 + " and " + num2 + " is " + add + ", " + sub + ", " + mul + ", and " + div); 
    }
}
