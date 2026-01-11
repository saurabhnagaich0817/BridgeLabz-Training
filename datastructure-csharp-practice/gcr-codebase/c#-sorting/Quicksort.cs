using System;

class QuickSort
{
    static void Main()
    {
        int[] prices = { 450, 120, 600, 300, 200 };

        QuickSort(prices, 0, prices.Length - 1);

        Console.WriteLine("Sorted Product Prices:");
        for(int i = 0; i < prices.Length; i++)
        {
            Console.Write(prices[i] + " ");
        }
    }

    static void QuickSort(int[] arr, int low, int high)
    {
        if(low < high)
        {
            int p = Partition(arr, low, high);

            QuickSort(arr, low, p - 1);
            QuickSort(arr, p + 1, high);
        }
    }

    static int Partition(int[] arr, int low, int high)
    {
        int pivot = arr[high];  
        int i = low - 1;

        for(int j = low; j < high; j++)
        {
            if(arr[j] < pivot)
            {
                i++;
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }

        int t = arr[i + 1];
        arr[i + 1] = arr[high];
        arr[high] = t;

        return i + 1;
    }
}
