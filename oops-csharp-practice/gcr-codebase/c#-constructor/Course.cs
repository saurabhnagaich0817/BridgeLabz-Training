using System;

class Course
{
    // Instance data members
    private string title;
    private int months;
    private double charges;

    // Static data member
    private static string university = "GLA University";

    // Constructor
    public Course(string title, int months, double charges)
    {
        this.title = title;
        this.months = months;
        this.charges = charges;
    }

    // Instance method
    public void ShowDetails()
    {
        Console.WriteLine("Institute Name : " + university);
        Console.WriteLine("Course Title   : " + title);
        Console.WriteLine("Duration       : " + months + " months");
        Console.WriteLine("Fee            : ₹" + charges);
    }

    // Static method
    public static void SetInstitute(string name)
    {
        university = name;
    }
}

class CourseDemo
{
    static void Main()
    {
        Course courseA = new Course("AIML", 6, 45000);
        Course courseB = new Course("Data Science", 8, 60000);
        Course.SetInstitute("GLA University");

        courseA.ShowDetails();
        Console.WriteLine();
        courseB.ShowDetails();
    }
}
