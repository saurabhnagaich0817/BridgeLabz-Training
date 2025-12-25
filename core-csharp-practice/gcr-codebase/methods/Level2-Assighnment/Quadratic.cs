using System;

class Quadratic
{
    static double[] Findroot(double a, double b, double c)
    {
        double delt = b * b - 4 * a * c;
        if (delt < 0) return new double[0];
        if (delt == 0) return new double[] { -b / (2 * a) };
double sqrt = Math.Sqrt(delt);
        return new double[]{ (-b + sqrt) / (2 * a),(-b - sqrt) / (2 * a)
        };
    }

    static void Main()
    {
        Console.Write("Enter a b c: ");
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
        double c = Convert.ToDouble(Console.ReadLine());

        double[] root = Findroot(a, b, c);

        if (root.Length == 0)
            Console.WriteLine("No real root");
        else
            foreach (double r in root) Console.WriteLine("Root: " + r);
    }
}
