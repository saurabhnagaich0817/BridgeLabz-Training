using System;
class TemperatureAnalyzer
{
  static void Main()
    {
        TemperatureAnalyzerr();
    }
  static void TemperatureAnalyzerr()
    {
        float[,] temperature = new float[7, 24];
        float[] avg = new float[7];
// initialize random number generator
        Random rand = new Random();

        // Auto-generate temperature
        for(int day = 0; day < 7; day++)
        {
            for(int h = 0; h < 24; h++)
            {
                // 15.0 to 45.0 temperature
                temperature[day, h] = 15 +(float)rand.NextDouble() * 30;
            }
        }

        // Calculate average per day
        for(int day = 0; day < 7; day++)
        {
            float sum = 0;
            for(int h = 0; h < 24; h++)
            {
                sum += temperature[day, h];
            }
            avg[day] = sum / 24;
            Console.WriteLine($"Average temperature of Day {day + 1}: {avg[day]}");
        }

        // Find hottest & coldest day
        float hottest = avg[0];
        float coldest = avg[0];
        int hotday = 1, coldday = 1;
// traversing through days
        for(int day = 1; day < 7; day++)
        {
            if(avg[day] > hottest)
            {
                hottest = avg[day];
                hotday = day + 1;
            }
            if(avg[day] < coldest)
            {
                coldest = avg[day];
                coldday = day + 1;
            }
        }
        Console.WriteLine($"Hottest Day: Day {hotday} with Avg Temp {hottest}");
        Console.WriteLine($"Coldest Day: Day {coldday} with Avg Temp {coldest}");
    }

}