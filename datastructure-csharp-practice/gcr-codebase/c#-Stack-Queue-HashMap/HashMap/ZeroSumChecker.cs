using System;

class ZeroSumChecker
{
    static void Main()
    {
        int[] numbers = { 3, 1, -4, 2, 2 };
        int[] prefixStore = new int[numbers.Length];

        int count = 0;
        int runningTotal = 0;
        bool isPresent = false;

        for (int idx = 0; idx < numbers.Length; idx++)
        {
            runningTotal += numbers[idx];

            if (runningTotal == 0)
            {
                isPresent = true;
                break;
            }

            for (int k = 0; k < count; k++)
            {
                if (prefixStore[k] == runningTotal)
                {
                    isPresent = true;
                    break;
                }
            }

            prefixStore[count++] = runningTotal;
        }

        Console.WriteLine(isPresent);
    }
}
