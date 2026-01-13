using System;

class FirstlastOccurence
{
    static void Main()
    {
        int[] numbers = { 1, 2, 2, 2, 3, 4 };
        int key = 2;

        int startIndex = -1, endIndex = -1;
        int left = 0, right = numbers.Length - 1;

      
        while (left <= right)
        {
            int center = (left + right) / 2;

            if (numbers[center] == key)
            {
                startIndex = center;
                right = center - 1;
            }
            else if (numbers[center] < key)
            {
                left = center + 1;
            }
            else
            {
                right = center - 1;
            }
        }

        left = 0;
        right = numbers.Length - 1;

        // Find last position
        while (left <= right)
        {
            int center = (left + right) / 2;

            if (numbers[center] == key)
            {
                endIndex = center;
                left = center + 1;
            }
            else if (numbers[center] < key)
            {
                left = center + 1;
            }
            else
            {
                right = center - 1;
            }
        }

        Console.WriteLine("First Occurrence: " + startIndex);
        Console.WriteLine("Last Occurrence: " + endIndex);
    }
}
