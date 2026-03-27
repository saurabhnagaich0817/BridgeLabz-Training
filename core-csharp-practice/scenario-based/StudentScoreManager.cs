using System;
class StudentScoreManager
{
  static void Main()
  {
    StudentScoreManager();
  }
     static void StudentScoreManager()
    {
        Console.Write("Enter number of students: ");
        int n = Convert.ToInt32(Console.ReadLine());
// create array to hold scores
        int[] scores = new int[n];
      for(int i = 0; i < n; i++)
        {
            Console.Write($"Enter score of student {i + 1}: ");
            int score = Convert.ToInt32(Console.ReadLine());
// validate score
            if(score < 0)
            {
                Console.WriteLine("Invalid score! Enter again.");
                i--;
            }
            else
            {
                scores[i] = score;
            }
        }
// calculate sum, max, min
        int sum = 0;
        int max = scores[0];
        int min = scores[0];

        for(int i = 0; i < n; i++)
        {
            sum += scores[i];
// check for max and min
            if(scores[i] > max) max = scores[i];
            if(scores[i] < min) min = scores[i];
        }

        float average =(float)sum / n;
// print results
        Console.WriteLine($"Average Score: {average}");
        Console.WriteLine($"Highest Score: {max}");
        Console.WriteLine($"Lowest Score: {min}");
// print scores above average
        Console.WriteLine("Scores above average:");
        for(int i = 0; i < n; i++)
        {
            if(scores[i] > average)
                Console.WriteLine(scores[i]);
        }
    }
}
