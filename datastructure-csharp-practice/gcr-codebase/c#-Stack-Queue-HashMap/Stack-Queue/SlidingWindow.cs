using System;

class WindowMaximum
{
    static void Main()
    {
        int[] numbers = { 4, 2, 12, 3, 8, 7, 9, 10 };
        int windowSize = 4;

        int[] indexQueue = new int[numbers.Length];
        int start = 0, end = -1;

        for(int pos = 0; pos < numbers.Length; pos++)
        {
            if(start <= end && indexQueue[start] <= pos - windowSize)
                start++;

            while(start <= end && numbers[indexQueue[end]] <= numbers[pos])
                end--;

            indexQueue[++end] = pos;
             if(pos >= windowSize - 1)
                Console.Write(numbers[indexQueue[start]] + " ");
        }
    }
}
