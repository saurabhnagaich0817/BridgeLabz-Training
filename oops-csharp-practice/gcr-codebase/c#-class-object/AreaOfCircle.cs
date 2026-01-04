using System;

// Circle class
class AreaOfCircle
{
    // Data member
    public double radius;

    //  calculate area
    public double CalculateArea()
    {
        return 3.14 * radius * radius;
    }

    //  calculate circumference
    public double CalculateCircumference()
    {
        return 2 * 3.14 * radius;
    }

    // Method to display results
    public void Display()
    {
        Console.WriteLine("Radius          : " + radius);
        Console.WriteLine("Area            : " + CalculateArea());
        Console.WriteLine("Circumference   : " + CalculateCircumference());
    }
}


class Program
{
    static void Main()
    {
        // Create object of Circle class
        Circle c = new Circle();

        // Assign radius
        c.radius = 7;

        // Display area and circumference
        c.Display();
    }
}
