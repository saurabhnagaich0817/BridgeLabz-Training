using System;

class RandomNO
{
    static int[] random(int size)
    {
        Random rand = new Random();
        int[] arr = new int[size];

        for (int i = 0; i < size; i++)
            arr[i] = rand.Next(1000, 10000);

        return arr;
    }

    static double[] FindAverageMinMax(int[] numbers)
    {
        int min = numbers[0], max = numbers[0];
        int sum = 0;

        foreach (int n in numbers)
        {
            sum += n;
            min = Math.Min(min, n);
            max = Math.Max(max, n);
        }

        return new double[] { sum / (double)numbers.Length, min, max };
    }

    static void Main()
    {
        int[] arr = random(5);

        foreach (int n in arr) Console.Write(n + " ");

        double[] result = FindAverageMinMax(arr);
        Console.WriteLine($"\nAverage: {result[0]} Min: {result[1]} Max: {result[2]}");
    }
}
