using System;

class Learner
{
    // Public member
    public int regNo;

    // Protected member
    protected string studentName;

    // Private member
    private double gradePoint;

    // Setter for CGPA
    public void AssignCGPA(double value)
    {
        gradePoint = value;
    }

    // Getter for CGPA
    public double FetchCGPA()
    {
        return gradePoint;
    }

    // Setter for name
    public void AssignName(string name)
    {
        studentName = name;
    }
}

class PGStudent : Learner
{
    public void ShowDetails()
    {
        Console.WriteLine("Registration No : " + regNo);
        Console.WriteLine("Student Name   : " + studentName); // protected access
        Console.WriteLine("CGPA           : " + FetchCGPA());
    }
}

class StudentApp
{
    static void Main()
    {
        PGStudent student = new PGStudent();

        student.regNo = 101;
        student.AssignName("Saurabh");
        student.AssignCGPA(8.9);

        student.ShowDetails();
    }
}
