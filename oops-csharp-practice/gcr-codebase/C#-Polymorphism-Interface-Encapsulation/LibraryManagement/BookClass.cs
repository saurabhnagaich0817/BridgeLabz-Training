// Book class
public class Book : LibraryItem, IReservable
{
    private bool isAvailable = true;
    private string borrowerName;

    public Book(string id, string title, string author)
        : base(id, title, author) { }

    public override int GetLoanDuration()
    {
        return 21; // 3 weeks
    }

    public void ReserveItem(string borrower)
    {
        if (isAvailable)
        {
            borrowerName = borrower;
            isAvailable = false;
            Console.WriteLine($"Book reserved by {borrowerName}");
        }
        else
        {
            Console.WriteLine("Book is already reserved.");
        }
    }

    public bool CheckAvailability()
    {
        return isAvailable;
    }
}

// Magazine class
public class Magazine : LibraryItem, IReservable
{
    private bool isAvailable = true;
    private string borrowerName;

    public Magazine(string id, string title, string author)
        : base(id, title, author) { }

    public override int GetLoanDuration()
    {
        return 7; // 1 week
    }

    public void ReserveItem(string borrower)
    {
        if (isAvailable)
        {
            borrowerName = borrower;
            isAvailable = false;
            Console.WriteLine($"Magazine reserved by {borrowerName}");
        }
        else
        {
            Console.WriteLine("Magazine is already reserved.");
        }
    }

    public bool CheckAvailability()
    {
        return isAvailable;
    }
}

// DVD class
public class DVD : LibraryItem, IReservable
{
    private bool isAvailable = true;
    private string borrowerName;

    public DVD(string id, string title, string author)
        : base(id, title, author) { }

    public override int GetLoanDuration()
    {
        return 3; // 3 days
    }

    public void ReserveItem(string borrower)
    {
        if (isAvailable)
        {
            borrowerName = borrower;
            isAvailable = false;
            Console.WriteLine($"DVD reserved by {borrowerName}");
        }
        else
        {
            Console.WriteLine("DVD is already reserved.");
        }
    }

    public bool CheckAvailability()
    {
        return isAvailable;
    }
}
