using System;
class Abundantno
{
  static void Main()
    {

      // reading input from user
        Console.Write("Enter a no: ");
        int no = int.Parse(Console.ReadLine());
        int sum = 0;

        // Find divisors
        for(int i = 1; i < no; i++)
        {
            if(no % i == 0)
            {
                sum = sum + i;
            }
        }

        // Check abundant condition
        if(sum > no)
            Console.WriteLine("Abundant no");
        else
            Console.WriteLine("Not an Abundant no");
    }
}
