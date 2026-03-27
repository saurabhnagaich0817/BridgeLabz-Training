using System;

class DistanceConverter
{
    static void Main(string[] args)
    {
        //  Declaring  the distance in kilometers
        double kilometers =10.8;

        // Conversion factor from km to miles
        double kmToMiles = 1.6;

      //  Converting  kilometers to miles
        double miles = kilometers / kmToMiles;

        //  Displaying  the result
        Console.WriteLine("The distance " +kilometers+" km in miles is "+miles);
    }
}


  