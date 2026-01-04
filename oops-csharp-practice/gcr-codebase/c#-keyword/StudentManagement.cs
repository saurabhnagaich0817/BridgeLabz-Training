using System;

class Learner
{
    public static string InstituteName = "Tech Valley Institute";
    private static int learnerCount = 0;

    public readonly int EnrollmentId;
    public string FullName;
    public char PerformanceGrade;

    public Learner(int id, string name, char grade)
    {
        this.EnrollmentId = id;
        this.FullName = name;
        this.PerformanceGrade = grade;
        learnerCount++;
    }

    public static void ShowLearnerCount()
    {
        Console.WriteLine("Total Learners: " + learnerCount);
    }

    public void ShowProfile(object data)
    {
        if (data is Learner)
        {
            Console.WriteLine($"{FullName}, ID: {EnrollmentId}, Grade: {PerformanceGrade}");
        }
    }
}

class AppRunner
{
    static void Main()
    {
        Learner l1 = new Learner(501, "Aarav", 'B');
        l1.ShowProfile(l1);
        Learner.ShowLearnerCount();
    }
}
