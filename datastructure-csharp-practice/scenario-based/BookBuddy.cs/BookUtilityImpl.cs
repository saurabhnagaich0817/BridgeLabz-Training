public class BookUtilityImpl : IBookService
{
    private BookLinkedList bookList;

    public BookUtilityImpl()
    {
        bookList = new BookLinkedList();
    }

    public void AddBook()
    {
        Console.Write("Enter book title: ");
        string title = Console.ReadLine();

        Console.Write("Enter author name: ");
        string author = Console.ReadLine();

        Book book = new Book(title, author);
        bookList.Add(book);

        Console.WriteLine("Book added successfully");
    }

    public void ViewAllBooks()
    {
        bookList.Display();
    }

    public void SearchByAuthor()
    {
        Console.Write("Enter author to search: ");
        string author = Console.ReadLine();

        bookList.SearchByAuthor(author);
    }

    public void SortBooksAlphabetically()
    {
        bookList.SortAlphabetically();
        Console.WriteLine("Books sorted alphabetically by title");
    }
}
