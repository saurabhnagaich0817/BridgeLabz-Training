using System;
class SumOfNN
{
static void Main(){
        //  taking number as input from user
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());
          // calculating sum of n natural numbers
        if (n > 0)
        {
            int sum = n * (n + 1) / 2;
            Console.WriteLine($"The sum of {n} natural numbers is {sum}");
        }
        else
        {
            Console.WriteLine($"The number {n} is not a natural number");
        }
    }
}

