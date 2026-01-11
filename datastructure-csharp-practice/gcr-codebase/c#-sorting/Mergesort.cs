using System;

class MergeSort
{
    static void Main()
    {
        int[] prices = { 500, 150, 300, 700, 250 };

        MergeSort(prices, 0, prices.Length - 1);

        Console.WriteLine("Sorted Book Prices:");
        for(int i = 0; i < prices.Length; i++)
        {
            Console.Write(prices[i] + " ");
        }
    }

    static void MergeSort(int[] arr, int left, int right)
    {
        if(left < right)
        {
            int mid =(left + right) / 2;

            // divide array
            MergeSort(arr, left, mid);
            MergeSort(arr, mid + 1, right);

            // merge sorted parts
            Merge(arr, left, mid, right);
        }
    }

    static void Merge(int[] arr, int left, int mid, int right)
    {
        int i = left;
        int j = mid + 1;
        int k = 0;

        int[] temp = new int[right - left + 1];

        while(i <= mid && j <= right)
        {
            if(arr[i] < arr[j])
                temp[k++] = arr[i++];
            else
                temp[k++] = arr[j++];
        }

        while(i <= mid)
            temp[k++] = arr[i++];

        while(j <= right)
            temp[k++] = arr[j++];

        for(int x = 0; x < temp.Length; x++)
            arr[left + x] = temp[x];
    }
}
