using System;

public class ExamQuestion
{
    private int id;
    private string text;
    private string correct;
    private int marks;

    public ExamQuestion(int id, string text, string correct, int marks)
    {
        this.id = id;
        this.text = text;
        this.correct = correct;
        this.marks = marks;
    }

    public int Id() => id;
    public string Correct() => correct;
    public int Marks() => marks;

    public override string ToString()
    {
        return id + ". " + text;
    }
}
