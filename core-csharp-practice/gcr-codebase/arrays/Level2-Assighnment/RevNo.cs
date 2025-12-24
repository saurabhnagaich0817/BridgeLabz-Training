using System;

class RevNo
{
    static void Main()
    {
      // Taking number as input from user
        Console.Write("Enter number: ");
        int num = int.Parse(Console.ReadLine());
//  Calculating number of digits
        int temp = num, count = 0;
        while (temp != 0)
        {
            count++;
            temp /= 10;
        }
// Storing digits in reverse order
        int[] digits = new int[count];
        for (int i = 0; i < count; i++)
        {
            digits[i] = num % 10;
            num /= 10;
        }
// Displaying reversed number
        Console.Write("Reversed Number: ");
        for (int i = 0; i < count; i++)
            Console.Write(digits[i]);
    }
}
