using System;

class BookNode
{
    public int bookId;
    public string bookTitle;
    public string authorName;
    public string genre;
    public bool isAvailable;

    public BookNode next;
    public BookNode prev;
}

class LibraryManager
{
    BookNode head;

    // Add book at beginning
    public void AddAtBeginning(int bookId, string bookTitle, string authorName, string genre, bool isAvailable)
    {
        BookNode newBook = new BookNode();
        newBook.bookId = bookId;
        newBook.bookTitle = bookTitle;
        newBook.authorName = authorName;
        newBook.genre = genre;
        newBook.isAvailable = isAvailable;

        newBook.next = head;
        newBook.prev = null;

        if (head != null)
            head.prev = newBook;

        head = newBook;
    }

    // Add book at end
    public void AddAtEnd(int bookId, string bookTitle, string authorName, string genre, bool isAvailable)
    {
        BookNode newBook = new BookNode();
        newBook.bookId = bookId;
        newBook.bookTitle = bookTitle;
        newBook.authorName = authorName;
        newBook.genre = genre;
        newBook.isAvailable = isAvailable;
        newBook.next = null;

        if (head == null)
        {
            newBook.prev = null;
            head = newBook;
            return;
        }

        BookNode temp = head;
        while (temp.next != null)
            temp = temp.next;

        temp.next = newBook;
        newBook.prev = temp;
    }

    // Add book at specific position
    public void AddAtPosition(int position, int bookId, string bookTitle, string authorName, string genre, bool isAvailable)
    {
        if (position == 1)
        {
            AddAtBeginning(bookId, bookTitle, authorName, genre, isAvailable);
            return;
        }

        BookNode temp = head;
        for (int i = 1; i < position - 1 && temp != null; i++)
            temp = temp.next;

        if (temp == null) return;

        BookNode newBook = new BookNode();
        newBook.bookId = bookId;
        newBook.bookTitle = bookTitle;
        newBook.authorName = authorName;
        newBook.genre = genre;
        newBook.isAvailable = isAvailable;

        newBook.next = temp.next;
        newBook.prev = temp;

        if (temp.next != null)
            temp.next.prev = newBook;

        temp.next = newBook;
    }

    // Remove book by ID
    public void RemoveBook(int bookId)
    {
        BookNode temp = head;

        while (temp != null)
        {
            if (temp.bookId == bookId)
            {
                if (temp.prev != null)
                    temp.prev.next = temp.next;
                else
                    head = temp.next;

                if (temp.next != null)
                    temp.next.prev = temp.prev;

                return;
            }
            temp = temp.next;
        }
    }

    // Search by title
    public void SearchByTitle(string bookTitle)
    {
        BookNode temp = head;
        while (temp != null)
        {
            if (temp.bookTitle == bookTitle)
            {
                DisplayBook(temp);
                return;
            }
            temp = temp.next;
        }
        Console.WriteLine("Book not found");
    }

    // Search by author
    public void SearchByAuthor(string authorName)
    {
        BookNode temp = head;
        while (temp != null)
        {
            if (temp.authorName == authorName)
                DisplayBook(temp);
            temp = temp.next;
        }
    }

    // Update availability
    public void UpdateAvailability(int bookId, bool isAvailable)
    {
        BookNode temp = head;
        while (temp != null)
        {
            if (temp.bookId == bookId)
            {
                temp.isAvailable = isAvailable;
                return;
            }
            temp = temp.next;
        }
    }

    // Display forward
    public void DisplayForward()
    {
        BookNode temp = head;
        while (temp != null)
        {
            DisplayBook(temp);
            temp = temp.next;
        }
    }

    // Display reverse
    public void DisplayReverse()
    {
        BookNode temp = head;
        if (temp == null) return;

        while (temp.next != null)
            temp = temp.next;

        while (temp != null)
        {
            DisplayBook(temp);
            temp = temp.prev;
        }
    }

    // Count total books
    public int GetTotalBooks()
    {
        int count = 0;
        BookNode temp = head;
        while (temp != null)
        {
            count++;
            temp = temp.next;
        }
        return count;
    }

    void DisplayBook(BookNode book)
    {
        Console.WriteLine(
            book.bookId + " " +
            book.bookTitle + " " +
            book.authorName + " " +
            book.genre + " Available:" +
            book.isAvailable
        );
    }
}

class Program
{
    static void Main()
    {
        LibraryManager library = new LibraryManager();

        library.AddAtBeginning(1, "CSharp", "Ravi", "Tech", true);
        library.AddAtEnd(2, "DSA", "Aman", "CS", false);
        library.AddAtPosition(2, 3, "DBMS", "Neha", "CS", true);

        library.DisplayForward();
        Console.WriteLine("Reverse Order:");
        library.DisplayReverse();

        Console.WriteLine("Total Books: " + library.GetTotalBooks());

        library.UpdateAvailability(2, true);
        library.SearchByTitle("DBMS");
    }
}
