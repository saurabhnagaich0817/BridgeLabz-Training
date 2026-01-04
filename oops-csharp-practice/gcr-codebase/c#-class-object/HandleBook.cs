using System;

// Book class
class HandleBook
{

    // Data members
    public string title;
    public string author;
    public double price;

    // Method to display book details
    public void DisplayDetails()
    {
        Console.WriteLine("Book Title  : " + title);
        Console.WriteLine("Author      : " + author);
        Console.WriteLine("Price       : " + price);
    }
}

// Main class
class Program
{
    static void Main()
    {
        // Creating object of Book class
        Book b = new Book();

        // Assigning values
        b.title = "C# Programming";
        b.author = "Herbert Schildt";
        b.price = 550;

        // Display book details
        b.DisplayDetails();
    }
}
