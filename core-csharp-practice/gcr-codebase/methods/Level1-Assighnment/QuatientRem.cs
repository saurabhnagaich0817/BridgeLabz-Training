using System;

class QuatentRem
{
    public static int[] findremquat(int number, int divisor)
    {
        int qutient = number / divisor;
        int remainder = number % divisor;
        return new int[] { qutient, remainder };
    }

    static void Main()
    {
      // taking number and divisor as input from user
        Console.Write("Enter number: ");
        int number = Convert.ToInt32(Console.ReadLine());
//  taking divisor as input from user
        Console.Write("Enter divisor: ");
        int divisor = Convert.ToInt32(Console.ReadLine());
// finding quotient and remainder
        int[] res = findremquat(number, divisor);
        Console.WriteLine("quotient: " + res[0]);
        Console.WriteLine("Remainder: " + res[1]);
    }
}
