class UniversityMain
{
    static void Main()
    {
        CourseManager<ExamCourse> exams = new CourseManager<ExamCourse>();
        exams.AddCourse(new ExamCourse { CourseName = "Science" });
        exams.EvaluateAll();
    }
}