using System;

class HeightConversion
{
    static void Main()
    {   
      //  declaring height in centimeters  and taking inputs
        double hcm, totalinch;
        int feet;
        double inch;
        //  taking height in cm from user
        Console.Write("Enter height in centimeters: ");
        hcm = Convert.ToDouble(Console.ReadLine());
        //  converting cm to inches
        totalinch = hcm / 2.54;
      
        feet = (int)(totalinch / 12);
        inch = totalinch % 12;
        //  printing the output
        Console.WriteLine("Your Height in cm is " + hcm +" while in feet is " + feet +" and inches is " + inch);
    }
}
