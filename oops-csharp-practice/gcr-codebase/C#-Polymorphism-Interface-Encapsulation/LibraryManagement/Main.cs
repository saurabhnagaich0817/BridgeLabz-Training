class Program
{
    static void Main(string[] args)
    {
        // Create library items
        LibraryItem book1 = new Book("B001", "C# Programming", "John Doe");
        LibraryItem mag1 = new Magazine("M001", "Tech Monthly", "Jane Smith");
        LibraryItem dvd1 = new DVD("D001", "Inception", "Christopher Nolan");

        // Array of LibraryItems
        LibraryItem[] items = { book1, mag1, dvd1 };

        Console.WriteLine("----- Library Items -----\n");

        foreach (var item in items)
        {
            item.GetItemDetails();
            Console.WriteLine($"Loan Duration: {item.GetLoanDuration()} days");

            if (item is IReservable reservableItem)
            {
                Console.WriteLine("Availability: " + (reservableItem.CheckAvailability() ? "Available" : "Not Available"));
                reservableItem.ReserveItem("Alice"); 
                Console.WriteLine("Availability after reservation: " + (reservableItem.CheckAvailability() ? "Available" : "Not Available"));
            }

            Console.WriteLine();
        }
    }
}
