using System;

class PairSum
{
    static void Main()
    {
        int[] arr = { 4, 5, 6, 9 };
        int target = 13;

        bool found = false;

        for (int i = 0; i < arr.Length; i++)
            for (int j = i + 1; j < arr.Length; j++)
                if (arr[i] + arr[j] == target)
                    found = true;

        Console.WriteLine(found);
    }
}