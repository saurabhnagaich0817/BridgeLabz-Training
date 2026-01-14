using System;
using System.Diagnostics;

class SortingExperiment
{
    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
            for (int j = 0; j < n - i - 1; j++)
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
    }

    static void MergeSort(int[] arr, int l, int r)
    {
        if (l < r)
        {
            int m = (l + r) / 2;
            MergeSort(arr, l, m);
            MergeSort(arr, m + 1, r);
            Merge(arr, l, m, r);
        }
    }

    static void Merge(int[] arr, int l, int m, int r)
    {
        int n1 = m - l + 1, n2 = r - m;
        int[] L = new int[n1];
        int[] R = new int[n2];

        Array.Copy(arr, l, L, 0, n1);
        Array.Copy(arr, m + 1, R, 0, n2);

        int i = 0, j = 0, k = l;
        while (i < n1 && j < n2)
            arr[k++] = (L[i] <= R[j]) ? L[i++] : R[j++];

        while (i < n1) arr[k++] = L[i++];
        while (j < n2) arr[k++] = R[j++];
    }

    static void QuickSort(int[] arr, int low, int high)
    {
        if (low < high)
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
        for (int j = low; j < high; j++)
            if (arr[j] < pivot)
            {
                i++;
                (arr[i], arr[j]) = (arr[j], arr[i]);
            }
        (arr[i + 1], arr[high]) = (arr[high], arr[i + 1]);
        return i + 1;
    }

    static void Main()
    {
        int size = 10000;   // try 1000, 10000
        Random rand = new Random();
        int[] data = new int[size];

        for (int i = 0; i < size; i++)
            data[i] = rand.Next(1, size);

        Stopwatch sw = new Stopwatch();

        // Bubble Sort
        int[] a1 = (int[])data.Clone();
        sw.Start();
        BubbleSort(a1);
        sw.Stop();
        Console.WriteLine("Bubble Sort Time: " + sw.ElapsedMilliseconds + " ms");

        // Merge Sort
        int[] a2 = (int[])data.Clone();
        sw.Restart();
        MergeSort(a2, 0, a2.Length - 1);
        sw.Stop();
        Console.WriteLine("Merge Sort Time: " + sw.ElapsedMilliseconds + " ms");

        // Quick Sort
        int[] a3 = (int[])data.Clone();
        sw.Restart();
        QuickSort(a3, 0, a3.Length - 1);
        sw.Stop();
        Console.WriteLine("Quick Sort Time: " + sw.ElapsedMilliseconds + " ms");
    }
}
       