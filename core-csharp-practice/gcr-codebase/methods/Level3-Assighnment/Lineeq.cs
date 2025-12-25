using System;

class lineeq
{
    static void Main()
    {
        Console.Write("enter x1: ");
        double x1 = double.Parse(Console.ReadLine());

        Console.Write("enter y1: ");
        double y1 = double.Parse(Console.ReadLine());

        Console.Write("enter x2: ");
        double x2 = double.Parse(Console.ReadLine());

        Console.Write("enter y2: ");
        double y2 = double.Parse(Console.ReadLine());

        double dist = distance(x1, y1, x2, y2);
        Console.WriteLine("distance = " + dist);

        double[] res = line(x1, y1, x2, y2);
        Console.WriteLine("slope m = " + res[0]);
        Console.WriteLine("y-intercept b = " + res[1]);
        Console.WriteLine("equation: y = " + res[0] + "x + " + res[1]);
    }

    static double distance(double x1, double y1, double x2, double y2)
    {
        double d = Math.Sqrt(
            Math.Pow(x2 - x1, 2) +
            Math.Pow(y2 - y1, 2)
        );
        return d;
    }

    static double[] line(double x1, double y1, double x2, double y2)
    {
        double m =(y2 - y1) /(x2 - x1);
        double b = y1 - m * x1;

        double[] arr = new double[2];
        arr[0] = m;
        arr[1] = b;

        return arr;
    }
}
