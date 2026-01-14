using System;

class SearchComparison
{
    static int LinearSearch(int[] arr, int target)
    {
        for (int i = 0; i < arr.Length; i++)
            if (arr[i] == target)
                return i;
        return -1;
    }

    static int BinarySearch(int[] arr, int target)
    {
        int low = 0, high = arr.Length - 1;

        while (low <= high)
        {
            int mid = (low + high) / 2;
            if (arr[mid] == target) return mid;
            else if (arr[mid] < target) low = mid + 1;
            else high = mid - 1;
        }
        return -1;
    }

    static void Main()
    {
        int[] data = new int[1000000];
        for (int i = 0; i < data.Length; i++)
            data[i] = i + 1;

        int target = 999999;

        LinearSearch(data, target);
        BinarySearch(data, target);
    }
}
