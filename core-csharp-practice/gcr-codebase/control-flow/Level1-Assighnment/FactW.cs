using System;

class FactW
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int n = int.Parse(Console.ReadLine());

        if(n > 0)
        {
          // calculating factorial using while loop
            int fact = 1;
            int i = 1;

            while(i <= n)
            {
                fact *= i;
                i++;
            }
            //  printing factorial
            Console.WriteLine("Factorial is " + fact);
        }
        else
        {
            Console.WriteLine("Enter positive number");
        }
    }
}
