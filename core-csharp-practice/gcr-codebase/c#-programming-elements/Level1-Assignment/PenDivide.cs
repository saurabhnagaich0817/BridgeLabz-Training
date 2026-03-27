using System;
class PenDivide
{
  static void Main()
  { 
    // Given values of  total pens and number of students
     
    int totalpen=14;
    int std=3;
    // Calculating pen per student and remaining pens
    int pendivide=totalpen/std;
    int remainingpen=totalpen%std;
    // Printing the pen per student and remaining pens
     Console.WriteLine("The Pen Per Student is " + pendivide +" and the remaining pen not distributed is " + remainingpen );
  }
}