using System;

class SwapToNumber
{static void Main(){
  // input from user
        Console.Write("Enter first number: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int num2 = int.Parse(Console.ReadLine());
        // swapping numbers

        int temp = num1;
        num1 = num2;
        num2 = temp;
      //   printing the swapping numbers
        Console.WriteLine("The swapped numbers are " + num1 + " and " + num2);
    }
}
