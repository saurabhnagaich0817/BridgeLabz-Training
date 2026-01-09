using System;

class TwoSum
{
    static void Main()
    {
        int[] numbers = { 4, 6, 1, 8, 3 };
        int requiredSum = 9;

        for (int first = 0; first < numbers.Length; first++)
        {
            for (int second = first + 1; second < numbers.Length; second++)
            {
                if (numbers[first] + numbers[second] == requiredSum)
                {
                    Console.WriteLine(first + " " + second);
                    return;
                }
            }
        }
    }
}
