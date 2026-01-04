using System;

class Publication
{
    public static string ReadingCenter = "Knowledge Hub";

    public readonly string BookCode;
    public string BookName;
    public string Writer;

    public Publication(string code, string name, string writer)
    {
        this.BookCode = code;
        this.BookName = name;
        this.Writer = writer;
    }

    public static void ShowCenterName()
    {
        Console.WriteLine("Library Name: " + ReadingCenter);
    }

    public void ShowBookInfo(object data)
    {
        if (data is Publication)
        {
            Console.WriteLine($"{BookName} written by {Writer}, Code: {BookCode}");
        }
    }
}

class AppStart
{
    static void Main()
    {
        Publication pub = new Publication("BK789", "The Pragmatic Programmer", "Andrew Hunt");
        Publication.ShowCenterName();
        pub.ShowBookInfo(pub);
    }
}
