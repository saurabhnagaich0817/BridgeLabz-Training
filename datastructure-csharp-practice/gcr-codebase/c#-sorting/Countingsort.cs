using System;

class CountingSort
{
    static void Main()
    {
        int[] ages = { 12, 15, 10, 14, 18, 12, 16, 10 };

        int minAge = 10;
        int maxAge = 18;

        int range = maxAge - minAge + 1;
        int[] count = new int[range];
        int[] output = new int[ages.Length];

        // Step 1: Count frequency
        for(int i = 0; i < ages.Length; i++)
        {
            count[ages[i] - minAge]++;
        }

        // Step 2: Cumulative count
        for(int i = 1; i < count.Length; i++)
        {
            count[i] += count[i - 1];
        }

        // Step 3: Place elements in correct position
        for(int i = ages.Length - 1; i >= 0; i--)
        {
            int age = ages[i];
            output[count[age - minAge] - 1] = age;
            count[age - minAge]--;
        }

        Console.WriteLine("Sorted Students Ages:");
        for(int i = 0; i < output.Length; i++)
        {
            Console.Write(output[i] + " ");
        }
    }
}
