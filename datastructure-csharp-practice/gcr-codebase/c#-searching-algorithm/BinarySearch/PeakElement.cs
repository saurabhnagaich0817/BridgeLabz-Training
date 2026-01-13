using System;

class PeakElement
{
    static void Main()
    {
        int[] arr = { 1,8,56,65,45,78 };

        int low = 0, high = arr.Length - 1;

        while (low < high)
        {
            int mid = (low + high) / 2;

            if (arr[mid] < arr[mid + 1])
                low = mid + 1;
            else
                high = mid;
        }

        Console.WriteLine("Peak Element Index: " + low);
    }
}