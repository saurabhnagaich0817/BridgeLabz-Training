using System;

class FactFor
{

    static void Main()
    {

      // reading input from user
        Console.Write("Enter number: ");
        int n = int.Parse(Console.ReadLine());
        if(n > 0)
        {

          // calculating factorial using for loop
            int fact = 1;
            for(int i = 1; i <= n; i++)
                fact *= i;

            Console.WriteLine("Factorial is " + fact);
        }
        else
        {
            Console.WriteLine("Enter positive number");
        }
    }
}
