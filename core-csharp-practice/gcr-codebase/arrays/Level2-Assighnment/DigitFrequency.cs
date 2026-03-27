using System;

class DigitFrequency
{
    static void Main()
    {
      // Taking number as input from user
        Console.Write("Enter number: ");
        int num = int.Parse(Console.ReadLine());
//  Initializing frequency array
        int[] freq = new int[10];
      while(num != 0)
        {
            int d = num % 10;
            freq[d]++;
            num /= 10;
        }
        for(int i = 0; i < 10; i++)
            Console.WriteLine($"Digit {i} = {freq[i]} times");
    }
}
