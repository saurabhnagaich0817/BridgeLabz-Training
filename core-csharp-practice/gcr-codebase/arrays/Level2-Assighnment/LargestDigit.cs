using System;

class lDigit
{
    static void Main()
    {
      // Taking number as input from user
        Console.Write("Enter number: ");
        int num = int.Parse(Console.ReadLine());
// Initializing variables to store d
        int maxd = 10;
        int[] d = new int[maxd];
        int idxx = 0;
// Extracting digits from the number
        while (num != 0 && idxx < maxd)
        {
            d[idxx++] = num % 10;
            num /= 10;
        }

        int l = 0, secondl = 0;
// Finding largest and second largest digits
        for (int i = 0; i < idxx; i++)
        {
            if (d[i] > l)
            {
                secondl = l;
                l = d[i];
            }
            else if (d[i] > secondl && d[i] != l)
            {
                secondl = d[i];
            }
        }
// Displaying largest and second largest digits
        Console.WriteLine("l = " + l);
        Console.WriteLine("Second l = " + secondl);
    }
}
