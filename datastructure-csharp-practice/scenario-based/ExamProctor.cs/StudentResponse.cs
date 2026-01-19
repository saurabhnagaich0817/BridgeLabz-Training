using System;

public class StudentResponse
{
    private int qId;
    private string answerText;

    public StudentResponse(int qId, string answerText)
    {
        this.qId = qId;
        this.answerText = answerText;
    }

    public int GetQId()
    {
        return qId;
    }

    public string GetAnswer()
    {
        return answerText;
    }

    public override string ToString()
    {
        return "Question: " + qId + " | Answer: " + answerText;
    }
}
