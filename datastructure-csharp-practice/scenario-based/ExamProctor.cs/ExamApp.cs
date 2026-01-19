
using System;

class ExamApp
{
    static void Main()
    {
        ExamService service = new ExamService();
        ExamConsole menu = new ExamConsole(service);
        menu.Start();
    }
}
