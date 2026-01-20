using System;

public class AadharUtilityImpl : IAadharService
{
    private Aadhar[] records;

    public AadharUtilityImpl()
    {
        records = new Aadhar[]
        {
            new Aadhar(987654321012,"Rahul Sharma",28,"12-03-1996"),
            new Aadhar(123456789010,"Anita Verma",34,"05-08-1990"),
            new Aadhar(987654321010,"Amit Singh",41,"22-01-1983"),
            new Aadhar(123456789012,"Neha Gupta",25,"14-11-1998"),
            new Aadhar(555544443333,"Rohan Mehta",31,"09-06-1993"),
            new Aadhar(111122223333,"Pooja Jain",29,"18-02-1995")
        };
    }

    public void DisplayAll()
    {
        for (int i = 0; i < records.Length; i++)
        {
            Console.WriteLine(records[i]);
        }
    }

    public void SortAadhar()
    {
        PerformRadixSort();
        Console.WriteLine("Aadhar records sorted successfully.");
    }

    // -------- RADIX SORT --------
    private void PerformRadixSort()
    {
        long place = 1;

        for (int pass = 0; pass < 12; pass++)
        {
            StableCountingSort(place);
            place *= 10;
        }
    }

    // -------- COUNTING SORT --------
    private void StableCountingSort(long place)
    {
        int size = records.Length;
        Aadhar[] sortedOutput = new Aadhar[size];
        int[] freq = new int[10];

        for (int i = 0; i < size; i++)
        {
            int digit = (int)((records[i].GetAadharNumber() / place) % 10);
            freq[digit]++;
        }

        for (int i = 1; i < 10; i++)
        {
            freq[i] += freq[i - 1];
        }

        for (int i = size - 1; i >= 0; i--)
        {
            int digit = (int)((records[i].GetAadharNumber() / place) % 10);
            sortedOutput[freq[digit] - 1] = records[i];
            freq[digit]--;
        }

        for (int i = 0; i < size; i++)
        {
            records[i] = sortedOutput[i];
        }
    }

    // -------- SEARCH --------
    public void SearchAadhar(long key)
    {
        int resultIndex = PerformBinarySearch(key);

        if (resultIndex == -1)
            Console.WriteLine("Aadhar record not found.");
        else
        {
            Console.WriteLine("Aadhar record found:");
            Console.WriteLine(records[resultIndex]);
        }
    }

    private int PerformBinarySearch(long key)
    {
        int start = 0;
        int end = records.Length - 1;

        while (start <= end)
        {
            int mid = (start + end) / 2;
            long midValue = records[mid].GetAadharNumber();

            if (midValue == key)
                return mid;
            else if (midValue < key)
                start = mid + 1;
            else
                end = mid - 1;
        }
        return -1;
    }
}
