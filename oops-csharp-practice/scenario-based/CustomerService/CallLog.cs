using System;

public class CallLog
{
    private string phoneNumber;
    private string message;
    private DateTime timeStamp;

    public CallLog(string phoneNumber, string message, DateTime timeStamp)
    {
        this.phoneNumber = phoneNumber;
        this.message = message;
        this.timeStamp = timeStamp;
    }

    public string PhoneNumber
    {
        get { return phoneNumber; }
    }

    public string Message
    {
        get { return message; }
    }

    public DateTime TimeStamp
    {
        get { return timeStamp; }
    }

    public void Display()
    {
        Console.WriteLine(
            "Number: " + phoneNumber +
            " | Time: " + timeStamp +
            " | Message: " + message
        );
    }
}
