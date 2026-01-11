using System;

class MarketSpan
{
    static void Main()
    {
        int[] rates = { 120, 90, 50, 60, 55, 95, 110 };
        int length = rates.Length;

        int[] result = new int[length];
        int[] indexStack = new int[length];
        int stackTop = -1;

        for(int day = 0; day < length; day++)
        {
            while(stackTop != -1 && rates[indexStack[stackTop]] <= rates[day])
                stackTop--;

            if(stackTop == -1)
                result[day] = day + 1;
            else
                result[day] = day - indexStack[stackTop];

            indexStack[++stackTop] = day;
        }

        for(int day = 0; day < length; day++)
            Console.Write(result[day] + " ");
    }
}
