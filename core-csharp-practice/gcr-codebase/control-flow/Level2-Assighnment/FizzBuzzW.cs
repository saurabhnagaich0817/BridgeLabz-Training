using System;

class FizzBuzzW
{
    static void Main()
    {
        Console.Write("Enter a positive no: ");
        int no = int.Parse(Console.ReadLine());
// FizzBuzz logic using while loop
        int i = 1;
// 
        while (i <= no )
        {
            if (i % 3 == 0 && i % 5 == 0)
                Console.WriteLine("FizzBuzz");
            else if (i % 3 == 0)
                Console.WriteLine("Fizz");
            else if (i % 5 == 0)
                Console.WriteLine("Buzz");
            else
                Console.WriteLine(i);

            i++;
        }
    }
}
