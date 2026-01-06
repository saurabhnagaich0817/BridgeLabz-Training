using System;

public class CallLogManager
{
    private CallLog[] logs;
    private int count;

    public CallLogManager(int size)
    {
        logs = new CallLog[size];
        count = 0;
    }

    public void AddCallLog()
    {
        if (count >= logs.Length)
        {
            Console.WriteLine("Log storage full.");
            return;
        }

        Console.Write("Enter phone number: ");
        string number = Console.ReadLine() ?? "";

        Console.Write("Enter message: ");
        string message = Console.ReadLine() ?? "";

        logs[count] = new CallLog(number, message, DateTime.Now);
        count++;

        Console.WriteLine("Call log added.");
    }

    public void SearchByKeyword()
    {
        Console.Write("Enter keyword: ");
        string keyword = Console.ReadLine() ?? "";

        bool found = false;

        for (int i = 0; i < count; i++)
        {
            if (logs[i].Message.Contains(keyword))
            {
                logs[i].Display();
                found = true;
            }
        }

        if (!found)
            Console.WriteLine("No matching logs found.");
    }

    public void FilterByTime()
    {
        Console.Write("Enter start time (yyyy-MM-dd HH:mm): ");
        DateTime start = DateTime.Parse(Console.ReadLine() ?? "");

        Console.Write("Enter end time (yyyy-MM-dd HH:mm): ");
        DateTime end = DateTime.Parse(Console.ReadLine() ?? "");

        bool found = false;

        for (int i = 0; i < count; i++)
        {
            if (logs[i].TimeStamp >= start && logs[i].TimeStamp <= end)
            {
                logs[i].Display();
                found = true;
            }
        }

        if (!found)
            Console.WriteLine("No logs in this time range.");
    }
}
