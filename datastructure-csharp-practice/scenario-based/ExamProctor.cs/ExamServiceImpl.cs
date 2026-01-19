using System;

class ExamService : IExamService
{
    private SimpleList questionHistory = new SimpleList();
    private SimpleList answers = new SimpleList();

    private ExamQuestion[] paper;
    private int index = 0;

    public ExamService()
    {
        LoadPaper();
        questionHistory.AddFirst(paper[0]);
    }

    private void LoadPaper()
    {
        paper = new ExamQuestion[]
        {
            new ExamQuestion(1,"Output of x=5; Console.WriteLine(x++);","5",1),
            new ExamQuestion(2,"Keyword for inheritance in C#?"," :",1),
            new ExamQuestion(3,"OOP full form?","Object Oriented Programming",1),
            new ExamQuestion(4,"LIFO data structure?","Stack",1),
            new ExamQuestion(5,"Default int value?","0",1),
            new ExamQuestion(6,"Loop that runs once minimum?","do-while",1),
            new ExamQuestion(7,"Stop loop keyword?","break",1),
            new ExamQuestion(8,"Equality operator?","==",1),
            new ExamQuestion(9,"Method overloading?","Same name different parameters",1),
            new ExamQuestion(10,"No-duplicate collection?","Set",1)
        };
    }

    public void DisplayQuestion()
    {
        Console.WriteLine(paper[index]);
    }

    public void SaveAnswer(string ans)
    {
        answers.AddLast(new StudentResponse(paper[index].Id(), ans));

        if (index < paper.Length - 1)
        {
            index++;
            questionHistory.AddFirst(paper[index]);
        }
    }

    public void MoveBack()
    {
        questionHistory.RemoveFirst();
        if (index > 0)
            index--;
    }

    public void FinishExam()
    {
        int total = 0;
        SimpleList.Node temp = answers.Head();

        while (temp != null)
        {
            StudentResponse res = (StudentResponse)temp.Data();

            foreach (var q in paper)
            {
                if (q.Id() == res.GetQId() &&
                    q.Correct().Equals(res.GetAnswer(),
                    StringComparison.OrdinalIgnoreCase))
                {
                    total += q.Marks();
                }
            }
            temp = temp.Next();
        }

        Console.WriteLine("Score: " + total + "/" + paper.Length);
    }
}
