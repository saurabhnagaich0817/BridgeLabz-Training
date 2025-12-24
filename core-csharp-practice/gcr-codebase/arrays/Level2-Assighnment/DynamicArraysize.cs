using System;

class DynamicArraysize
{
    static void Main()
    {
      // Taking number as input from user
        Console.Write("Enter number: ");
        int num = int.Parse(Console.ReadLine());
//  Initializing dynamic array for digit
        int maxd = 10;
        int[] digit = new int[maxd];
        int idxx = 0;

        while(num != 0)
        {
            if(idxx == maxd)
            {
                maxd += 10;
                int[] temp = new int[maxd];
                for(int i = 0; i < digit.Length; i++)
                    temp[i] = digit[i];
                digit = temp;
            }

            digit[idxx++] = num % 10;
            num /= 10;
        }
// Finding largest and second largest digits
        int larg = 0, scndlarg = 0;

        for(int i = 0; i < idxx; i++)
        {
            if(digit[i]>larg)
            {
                scndlarg = larg;
                larg = digit[i];
            }
            else if(digit[i]>scndlarg && digit[i] != larg)
            {
                scndlarg = digit[i];
            }
        }
// Displaying largest and second largest digits
        Console.WriteLine("larg = " + larg);
        Console.WriteLine("Second larg = " + scndlarg);
    }
}
