public class BookMenu
{
    private IBookService service;

    public BookMenu()
    {
        service = new BookUtilityImpl();
    }

    public void ShowMenu()
    {
        int choice;

        do
        {
            Console.WriteLine("\n=== BookBuddy Menu ===");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. View All Books");
            Console.WriteLine("3. Search by Author");
            Console.WriteLine("4. Sort Books Alphabetically");
            Console.WriteLine("5. Exit");
            Console.Write("Enter choice: ");

            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    service.AddBook();        // ✅ input utility lega
                    break;

                case 2:
                    service.ViewAllBooks();
                    break;

                case 3:
                    service.SearchByAuthor(); // ✅ input utility lega
                    break;

                case 4:
                    service.SortBooksAlphabetically();
                    break;

                case 5:
                    Console.WriteLine("Exiting...");
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }

        } while (choice != 5);
    }
}
