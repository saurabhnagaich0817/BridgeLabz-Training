using System;
class AverageMarks
{
    static void Main()
    {
        // Marks of Sam in each subject
        int maths = 94;
        int physics = 95;
        int chemistry = 96;

        // Total marks obtained
        int totalMarks = maths + physics + chemistry;

        // Maximum marks (100 per subject)
        int maxMarks = 100 * 3;

        // Average percent calculation
        double averagePercent = (totalMarks * 100.0) / maxMarks;

        Console.WriteLine("Sam's average mark in PCM is " + averagePercent + "%");
    }
}
