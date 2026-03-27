using System;

class Trigonometric
{
    public static double[] Trignofun(double angle)
    {
      
        double rad = angle * Math.PI / 180;
        double sin = Math.Sin(rad);
        double cos = Math.Cos(rad);
        double tan = Math.Tan(rad);
        return new double[] { sin, cos, tan };
    }

    static void Main()
    {
        Console.Write("Enter angle in degrees: ");
        double angle = Convert.ToDouble(Console.ReadLine());
// calculating sin, cos and tan
        double[] res = Trignofun(angle);
        Console.WriteLine("Sin: " + res[0]);
        Console.WriteLine("Cos: " + res[1]);
        Console.WriteLine("Tan: " + res[2]);
    }
}
