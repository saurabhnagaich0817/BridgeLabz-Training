using System;
class VolumeOfCylinder
{
  static void Main(string[] args)
    {
        double r= 5.0;
        double h= 10.0;
        double vol = Math.PI * Math.Pow(r, 2) * h;
        Console.WriteLine("The volume of the cylinder is: " + vol);
    }
}
