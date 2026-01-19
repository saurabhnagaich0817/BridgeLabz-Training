using System;

class ExamConsole
{
    private ExamService service;

    public ExamConsole(ExamService service)
    {
        this.service = service;
    }

    public void Start()
    {
        while (true)
        {
            Console.WriteLine("\n1 Show Question");
            Console.WriteLine("2 Answer Question");
            Console.WriteLine("3 Previous Question");
            Console.WriteLine("4 Submit Exam");
            Console.WriteLine("5 Exit");
            Console.Write("Choice: ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    service.DisplayQuestion();
                    break;

                case 2:
                    Console.Write("Your Answer: ");
                    service.SaveAnswer(Console.ReadLine());
                    break;

                case 3:
                    service.MoveBack();
                    break;

                case 4:
                    service.FinishExam();
                    return;

                case 5:
                    return;
            }
        }
    }
}
