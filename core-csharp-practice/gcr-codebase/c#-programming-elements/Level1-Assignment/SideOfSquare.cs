using System;

class sOfSquare
{
static void Main(){
        // taking input from user and declaring variables
        double per, s;

        Console.Write("Enter perimeter of square: ");
        per = Convert.ToDouble(Console.ReadLine());
          // side calculation
        s = per / 4;
  // length of side is printed
        Console.WriteLine("The length of the side is " + s +" whose perimeter is " + per );
    }
}
