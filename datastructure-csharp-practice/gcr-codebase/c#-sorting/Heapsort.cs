using System;

class HeapSort
{
    static void Main()
    {
        int[] salary = { 45000, 30000, 60000, 25000, 50000 };

        int n = salary.Length;

        // Build Max Heap
        for(int i = n / 2 - 1; i >= 0; i--)
        {
            Heapify(salary, n, i);
        }

        // Extract elements from heap
        for(int i = n - 1; i > 0; i--)
        {
            int temp = salary[0];
            salary[0] = salary[i];
            salary[i] = temp;

            Heapify(salary, i, 0);
        }

        Console.WriteLine("Sorted Salary Demands:");
        for(int i = 0; i < n; i++)
        {
            Console.Write(salary[i] + " ");
        }
    }

    static void Heapify(int[] arr, int n, int i)
    {
        int largest = i;
        int left = 2 * i + 1;
        int right = 2 * i + 2;

        if(left < n && arr[left] > arr[largest])
            largest = left;

        if(right < n && arr[right] > arr[largest])
            largest = right;

        if(largest != i)
        {
            int temp = arr[i];
            arr[i] = arr[largest];
            arr[largest] = temp;

            Heapify(arr, n, largest);
        }
    }
}
