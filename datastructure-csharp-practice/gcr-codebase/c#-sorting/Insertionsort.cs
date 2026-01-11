using System;

class InsertionSort
{
    static void Main()
    {
        int[] empIds = { 104, 101, 109, 102, 106 };

        for(int i = 1; i < empIds.Length; i++)
        {
            int key = empIds[i];
            int j = i - 1;

            while(j >= 0 && empIds[j] > key)
            {
                empIds[j + 1] = empIds[j];
                j--;
            }

            empIds[j + 1] = key;
        }

        Console.WriteLine("Sorted Employee IDs:");
        for(int i = 0; i < empIds.Length; i++)
        {
            Console.Write(empIds[i] + " ");
        }
    }
}
