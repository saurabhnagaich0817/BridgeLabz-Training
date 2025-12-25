using System;
class NumberCheck
{
    static int CheckNumber(int num)
    {
        if(num > 0) return 1;
        if(num < 0) return -1;
        return 0;
    }

    static void Main()
    {
      // taking number as input from user
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());
// checking number
        int res = CheckNumber(num);
        Console.WriteLine("res: " + res);
    }
}
