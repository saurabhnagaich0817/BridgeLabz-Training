using System;
class TriangleArea
{
static void Main(){
  // taking input from user and declaring variables
        double baseval, hgt, cmarea, areainch;
      //  
        Console.Write("Enter base in cm: ");
        baseval = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter hgt in cm: ");
        hgt = Convert.ToDouble(Console.ReadLine());
// area calculation
        cmarea = 0.5 * baseval * hgt;
        areainch = cmarea / 6.4516;
// printing the result
        Console.WriteLine( "Area of triangle is " + cmarea + " square cm and " + areainch + " square inches");
    }
}
