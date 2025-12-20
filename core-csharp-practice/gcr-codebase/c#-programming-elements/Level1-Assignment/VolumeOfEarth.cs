using System;
class VolumeOfEarth
{
  static void Main()
  {
    double radiuskm = 6378;                 
    // radius of Earth in km
        double pi = Math.PI;
        double kmtomiles = 0.621371;    
    //  as  1 km = 0.621371 miles

        // Volume in cubic kilometers
        double vkm= (4.0 / 3.0) * pi * Math.Pow(radiuskm, 3);

        // Convert radius to miles
        double rm = radiuskm * kmtomiles;

        // Volume in cubic miles
        double vvm = (4.0 / 3.0) * pi * Math.Pow(rm, 3);

        // Output
        Console.WriteLine("The volume of earth in cubic kilometers is " + vkm+ " and cubic miles is " + vvm);
  }
}