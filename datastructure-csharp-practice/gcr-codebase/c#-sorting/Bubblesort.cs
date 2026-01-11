using System;

class BubbleSort
{
    static void Main()
    {
        int[] marks = { 65, 40, 85, 55, 90 };

        for(int i = 0; i < marks.Length; i++)
        {
            for(int j = 0; j < marks.Length - 1; j++)
            {
                if(marks[j] > marks[j + 1])
                {
                    int temp = marks[j];
                    marks[j] = marks[j + 1];
                    marks[j + 1] = temp;
                }
            }
        }

        Console.WriteLine("Sorted Marks:");
        for(int i = 0; i < marks.Length; i++)
        {
            Console.Write(marks[i] + " ");
        }
    }
}
