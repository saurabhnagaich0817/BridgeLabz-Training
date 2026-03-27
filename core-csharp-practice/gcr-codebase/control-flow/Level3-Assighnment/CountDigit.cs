using System;

class CountDigit
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        int c = 0;
        // Loop till number becomes 0
        while(number != 0)
        {
            number = number / 10; // remove last digit
            c++;              // increase c
        }
      Console.WriteLine("Total number of digits = " + c);
    }
}
