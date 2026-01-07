using System;

// Abstract LibraryItem class
public abstract class LibraryItem
{
    private string itemId;
    private string title;
    private string author;

    // Encapsulated properties
    public string ItemId { get { return itemId; } set { itemId = value; } }
    public string Title { get { return title; } set { title = value; } }
    public string Author { get { return author; } set { author = value; } }

    public LibraryItem(string id, string title, string author)
    {
        ItemId = id;
        Title = title;
        Author = author;
    }

    // Abstract method for loan duration
    public abstract int GetLoanDuration(); // duration in days

    // Concrete method to display item details
    public void GetItemDetails()
    {
        Console.WriteLine($"ID: {ItemId}, Title: {Title}, Author: {Author}");
    }
}

// Interface for reservable items
public interface IReservable
{
    void ReserveItem(string borrowerName);
    bool CheckAvailability();
}
