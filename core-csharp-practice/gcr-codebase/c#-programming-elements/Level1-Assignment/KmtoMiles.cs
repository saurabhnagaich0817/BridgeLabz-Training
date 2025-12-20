using System;
class KmtoMiles
{
  static void Main()
  {    

    //   taking values in km and miles
      double km;
      double miles;
      Console.WriteLine("Enter distance in kilometers:");
      // converting string input to double
      km=Convert.ToDouble(Console.ReadLine());
      // converting km to miles
      miles=km/1.6;
      // printing the output 
      Console.WriteLine( "The total miles is " + miles + " mile for the given " + km + " km");
  }
}