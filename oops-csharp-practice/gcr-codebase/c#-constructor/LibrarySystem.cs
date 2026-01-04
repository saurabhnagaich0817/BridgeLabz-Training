using System;

class Publication
{
    // Public member
    public string bookCode;
    // Protected member
    protected string bookName;

    // Private member
    private string writer;

    // Setter for author
    public void AssignWriter(string name)
    {
        writer = name;
    }

    // Getter for author
    public string FetchWriter()
    {
        return writer;
    }

    // Setter for title
    public void AssignTitle(string title)
    {
        bookName = title;
    }
}

class DigitalBook : Publication
{
    public void ShowBookInfo()
    {
        Console.WriteLine("Book Code : " + bookCode);
        Console.WriteLine("Title     : " + bookName);   
        Console.WriteLine("Author    : " + FetchWriter());
    }
}

class LibraryApp
{
    static void Main()
    {
        DigitalBook db = new DigitalBook();

        db.bookCode = "978-0132350884";
        db.AssignTitle("Clean Code");
        db.AssignWriter("Robert C. Martin");

        db.ShowBookInfo();
    }
}
