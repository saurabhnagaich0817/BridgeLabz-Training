using System;

class Feet
{
    static void Main(){
      // taking input from user and declaring variables
        double feet, yrd, mile;

        Console.Write("Enter distance in feet: ");
        feet = Convert.ToDouble(Console.ReadLine());
//     yard to mile conversion
        yrd = feet / 3;
        mile = yrd / 1760;
Console.WriteLine("Distance in yrd is " + yrd +" and in mile is " + mile);
    }
}
