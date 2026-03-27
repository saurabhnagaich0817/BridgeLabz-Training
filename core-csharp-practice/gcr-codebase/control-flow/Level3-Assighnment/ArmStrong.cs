using System;class Armstrong
{
  static void Main()
    {
        // Taking input from user
        Console.Write("Enter a num: ");
        int num = int.Parse(Console.ReadLine());

        int orgnum = num;   // store original num
        int ans = 0;
 // Loop until num becomes 0
  while(num != 0)
        {
            int rem = num % 10;      // get last digit
            ans = ans +(rem * rem * rem); // cube and add
            num = num / 10;             // remove last digit
        }
// Check Armstrong condition
        if(ans == orgnum)
            Console.WriteLine("It is an Armstrong num");
        else
            Console.WriteLine("It is NOT an Armstrong num");
    }
}
