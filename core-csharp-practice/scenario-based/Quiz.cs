using System;

class Quiz
{
    // Quiz data:
    // Column 0 -> Question
    // Column 1 -> Correct Answer
    static string[,] quizData =
    {
        { "What is C#?", "programming language" },
        { "C# is developed by which company?", "microsoft" },
        { "Which symbol is used to end a statement in C#?", ";" },
        { "Which keyword is used to print output on console?", "Console.WriteLine" },
        { "Which data type is used for decimal values?", "float" },
        { "Which keyword is used to take input from user?", "ReadLine" },
        { "Which access modifier makes members available everywhere?", "public" },
        { "Which keyword is used to inherit a class?", ":" },
        { "Which loop is best when number of iterations is known?", "for" },
        { "Which file extension is used for C# source code?", ".cs" }
    };

    // Entry point
    public static void Main(string[] args)
    {
        Quiz quiz = new Quiz();
        quiz.Start();
    }

    // Main flow controller
    void Start()
    {
        Console.WriteLine("===== EDUQUIZ : STUDENT QUIZ GRADER =====");
        Console.WriteLine("1. Teacher");
        Console.WriteLine("2. Student");
        Console.Write("Select Role: ");

        int choice = Convert.ToInt32(Console.ReadLine());

        if (choice == 1)
        {
            TeacherMenu();
        }
        else if (choice == 2)
        {
            StudentMenu();
        }
        else
        {
            Console.WriteLine("Invalid Choice");
        }
    }

    // Teacher role
    void TeacherMenu()
    {
        Console.WriteLine("\n--- Teacher Panel ---");

        for (int i = 0; i < quizData.GetLength(0); i++)
        {
            Console.WriteLine("Q" + (i + 1) + ": " + quizData[i, 0]);
            Console.WriteLine("Answer: " + quizData[i, 1]);
            Console.WriteLine("-----------------------");
        }
    }

    // Student role
    void StudentMenu()
    {
        int totalQuestions = quizData.GetLength(0);
        string[] studentAnswers = new string[totalQuestions];

        Console.WriteLine("\n--- Quiz Started ---");

        for (int i = 0; i < totalQuestions; i++)
        {
            Console.WriteLine("Q" + (i + 1) + ": " + quizData[i, 0]);
            Console.Write("Your Answer: ");
            studentAnswers[i] = Console.ReadLine();
        }

        int score = CalculateScore(studentAnswers);
        ShowFeedback(studentAnswers);
        ShowResult(score, totalQuestions);
    }

    // Score calculation
    int CalculateScore(string[] studentAnswers)
    {
        int score = 0;

        for (int i = 0; i < quizData.GetLength(0); i++)
        {
            if (quizData[i, 1].Equals(studentAnswers[i], StringComparison.OrdinalIgnoreCase))
            {
                score++;
            }
        }

        return score;
    }

    // Per question feedback
    void ShowFeedback(string[] studentAnswers)
    {
        Console.WriteLine("\n--- Feedback ---");

        for (int i = 0; i < quizData.GetLength(0); i++)
        {
            if (quizData[i, 1].Equals(studentAnswers[i], StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Question " + (i + 1) + ": Correct");
            }
            else
            {
                Console.WriteLine(
                    "Question " + (i + 1) +
                    ": Incorrect | Correct Answer: " + quizData[i, 1]
                );
            }
        }
    }

    // Final result
    void ShowResult(int score, int total)
    {
        double percentage = (score * 100.0) / total;

        Console.WriteLine("\n--- Result ---");
        Console.WriteLine("Score: " + score + "/" + total);
        Console.WriteLine("Percentage: " + percentage + "%");

        if (percentage >= 40)
        {
            Console.WriteLine("Status: PASS");
        }
        else
        {
            Console.WriteLine("Status: FAIL");
        }
    }
}
