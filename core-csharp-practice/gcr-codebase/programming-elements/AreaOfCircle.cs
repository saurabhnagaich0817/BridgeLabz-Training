using System;
class AreaOfCircle
{
  public static void Main(string[] args)
    {
        Console.Write("Enter radius: ");
        double r= Convert.ToDouble(Console.ReadLine());

        double a= Math.PI * r * r;

        Console.WriteLine("Area of Circle="+a);
    }
}
