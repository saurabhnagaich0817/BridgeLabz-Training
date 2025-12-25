using System;

class SmallestLargest
{
    public static int[] find(int a, int b, int c)
    {
        int small = Math.Min(a, Math.Min(b, c));
        int large = Math.Max(a, Math.Max(b, c));
        return new int[] { small, large };
    }

    static void Main()
    {
        Console.Write("Enter three numbers: ");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());
// finding smallest and largest
        int[] res = find(a, b, c);
        Console.WriteLine("small: " + res[0]);
        Console.WriteLine("large: " + res[1]);
    }
}
