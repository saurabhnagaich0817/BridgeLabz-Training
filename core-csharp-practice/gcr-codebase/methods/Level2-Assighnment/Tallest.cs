using System;

class Tallest
{
    static int FindYoungest(int[] ages)
    {
        return Math.Min(ages[0], Math.Min(ages[1], ages[2]));
    }

    static int FindTallest(int[] heights)
    {
        return Math.Max(heights[0], Math.Max(heights[1], heights[2]));
    }

    static void Main()
    {
        int[] ages = new int[3];
        int[] heights = new int[3];
// taking ages and heights input
        for(int i = 0; i < 3; i++)
        {
            Console.Write("Enter age: ");
            ages[i] = Convert.ToInt32(Console.ReadLine());
// taking height input
            Console.Write("Enter height: ");
            heights[i] = Convert.ToInt32(Console.ReadLine());
        }
// finding youngest and tallest
        Console.WriteLine("Youngest Age: " + FindYoungest(ages));
        Console.WriteLine("Tallest Height: " + FindTallest(heights));
    }
}
