using System;

class StudentScoreCard
{
    // Method to generate random scores for Physics, Chemistry, Maths
    static int[,] GenerateScores(int numStudents)
    {
        Random random = new Random();
        int[,] scores = new int[numStudents, 3]; // 3 subjects: Physics, Chemistry, Maths

        for(int i = 0; i < numStudents; i++)
        {
            scores[i, 0] = random.Next(40, 101); // Physics 40-100
            scores[i, 1] = random.Next(40, 101); // Chemistry
            scores[i, 2] = random.Next(40, 101); // Maths
        }

        return scores;
    }

    // Method to calculate Total, avg, Percentage for each student
    static double[,] Calculateres(int[,] scores)
    {
        int numStudents = scores.GetLength(0);
        double[,] res = new double[numStudents, 3]; // 0: Total, 1: avg, 2: Percentage

        for(int i = 0; i < numStudents; i++)
        {
            int physics = scores[i, 0];
            int chemistry = scores[i, 1];
            int maths = scores[i, 2];

            int total = physics + chemistry + maths;
            double avg = total / 3.0;
            double percentage =(total / 300.0) * 100;

            res[i, 0] = Math.Round(total, 2);
            res[i, 1] = Math.Round(avg, 2);
            res[i, 2] = Math.Round(percentage, 2);
        }

        return res;
    }

    // Method to calculate grade based on percentage
    static string GetGrade(double percentage)
    {
        if(percentage >= 80)
            return "A";
        else if(percentage >= 70)
            return "B";
        else if(percentage >= 60)
            return "C";
        else if(percentage >= 50)
            return "D";
        else if(percentage >= 40)
            return "E";
        else
            return "R";
    }

    // Method to display scorecard
    static void DisplayScoreCard(int[,] scores, double[,] res)
    {
        Console.WriteLine("Student\tPhysics\tChemistry\tMaths\tTotal\tavg\tPercentage\tGrade");
        Console.WriteLine("----------------------------------------------------------------------");

        for(int i = 0; i < scores.GetLength(0); i++)
        {
            int physics = scores[i, 0];
            int chemistry = scores[i, 1];
            int maths = scores[i, 2];
            double total = res[i, 0];
            double avg = res[i, 1];
            double percentage = res[i, 2];
            string grade = GetGrade(percentage);

            Console.WriteLine($"{i + 1}\t{physics}\t{chemistry}\t\t{maths}\t{total}\t{avg}\t{percentage}\t\t{grade}");
        }
    }

    static void Main()
    {
        Console.Write("Enter number of students: ");
        int numStudents = int.Parse(Console.ReadLine());

        int[,] scores = GenerateScores(numStudents);       // Step 1: Generate random scores
        double[,] res = Calculateres(scores);     // Step 2: Calculate total, avg, percentage
        DisplayScoreCard(scores, res);                // Step 3: Display table with grade
    }
}
