using System;
class Primenum
{
    static void Main()
    {   
      // reading num input from user
        Console.Write("Enter a num: ");
        int num = int.Parse(Console.ReadLine());
// Checking prime condition
        bool pr = true;
// handling edge cases
        if(num <= 1)
            pr = false;
// checking for factors
        for(int i = 2; i < num; i++)
        {
            if(num % i == 0)
            {
                pr = false;
                break;
            }
        }
       if(pr)
            Console.WriteLine("Prime num");
        else
            Console.WriteLine("Not a Prime num");
    }
}
