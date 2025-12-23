using System;

class FizzBuzz
{
    static void Main() {
      // Taking input from user
        Console.Write("Enter num: ");
        int num = int.Parse(Console.ReadLine());
// Validating input
        if(num <= 0)
        {
            Console.WriteLine("Invalid Input");
            return;
        }
// Creating an array to store FizzBuzz ress
        string[] res = new string[num + 1];
// Calculating FizzBuzz values
        for(int i = 1; i <= num; i++)
        {
            if(i % 3 == 0 && i % 5 == 0)
                res[i] = "FizzBuzz";
            else if(i % 3 == 0)
                res[i] = "Fizz";
            else if(i % 5 == 0)
                res[i] = "Buzz";
            else
                res[i] = i.ToString();
        }
        // Displaying FizzBuzz ress

        for(int i = 1; i <= num; i++)
        {
            Console.WriteLine("Position " + i + " = " + res[i]);
        }
    }
}
