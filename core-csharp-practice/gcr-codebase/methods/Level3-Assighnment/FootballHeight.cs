using System;

class Football
{
    static void Main()
    {
        int[] heights = new int[11];
        Random random = new Random();

        // Generate random heights between 150 and 250
        for (int i = 0; i< heights.Length; i++)
        {
            heights[i] = random.Next(150, 251);
        }

        Console.WriteLine("Heights of Players:");
        foreach (int height in heights)
        {
            Console.Write(height + " ");
        }
        Console.WriteLine();

        int sum = FindSum(heights);
        double mean = FindMean(heights);
        int shortest = FindShortest(heights);
        int tallest = FindTallest(heights);

        Console.WriteLine("Shortest Height: " + shortest + " cm");
        Console.WriteLine("Tallest Height: " + tallest + " cm");
        Console.WriteLine("Mean Height: " + mean + " cm");
    }

    // Method to find sum of heights
    static int FindSum(int[] heights)
    {
        int sum = 0;
        for (int i = 0; i < heights.Length; i++)
        {
            sum += heights[i];
        }
        return sum;
    }

    // Method to find mean height
    static double FindMean(int[] heights)
    {
        int sum = FindSum(heights);
        return (double)sum / heights.Length;
    }

    // Method to find shortest height
    static int FindShortest(int[] heights)
    {
        int min = heights[0];
        for (int i = 1; i < heights.Length; i++)
        {
            if (heights[i] < min)
                min = heights[i];
        }
        return min;
    }

    // Method to find tallest height
    static int FindTallest(int[] heights)
    {
        int max = heights[0];
        for (int i = 1; i < heights.Length; i++)
        {
            if (heights[i] > max)
                max = heights[i];
        }
        return max;
    }
}
 