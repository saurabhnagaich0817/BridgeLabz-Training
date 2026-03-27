using System;

class HarshadNO
{
    static void Main()
    {
        Console.Write("Enter a no: ");
        int no = int.Parse(Console.ReadLine());
        int orgno = no;
        int s = 0;
      // Loop to find s of ds
        while(no != 0)
        {
            int d = no % 10;
            s = s + d;
            no = no / 10;
        }
       // Check divisibility
        if(orgno % s == 0)
            Console.WriteLine("Harshad no");
        else
            Console.WriteLine("Not a Harshad no");
    }
}
