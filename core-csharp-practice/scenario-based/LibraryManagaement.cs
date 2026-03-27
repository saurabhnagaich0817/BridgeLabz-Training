using System;

class LibraryManagement
{
    private string[,] books =
    {
        { "The Alchemist", "Arun Mehta", "Available" },
        { "Clean Code", "Rajesh Kumar", "Available" },
        { "The Pragmatic Programmer", "Anil Sharma", "Available" },
        { "Introduction to Algorithms", "Suman Reddy", "Available" },
        { "C Sharp Programming", "Deepak Singh", "Available" },
        { "Design Patterns", "Vikram Joshi", "Available" },
        { "Refactoring", "Ritu Verma", "Available" },
        { "Head First Java", "Kavita Patel", "Available" },
        { "Artificial Intelligence", "Suresh Iyer", "Available" },
        { "Machine Learning", "Neha Gupta", "Available" },
        { "Deep Learning", "Ananya Rao", "Available" },
        { "Operating System Concepts", "Manish Kapoor", "Available" },
        { "Computer Networks", "Pooja Desai", "Available" },
        { "Database System Concepts", "Rahul Jain", "Available" },
        { "Software Engineering", "Priya Nair", "Available" }
    };

    public static void Main()
    {
        LibraryManagement libraryApp = new LibraryManagement();
        libraryApp.Run();
    }

    private void Run()
    {
        Console.WriteLine("Choose your role:");
        Console.WriteLine("1. Librarian");
        Console.WriteLine("2. Member");

        if(!int.TryParse(Console.ReadLine(), out int role))
        {
            Console.WriteLine("Invalid input! Exiting.");
            return;
        }

        if (role == 1) ShowLibrarianMenu();
        else if (role == 2) ShowMemberMenu();
        else Console.WriteLine("Invalid choice.");
    }

    private void ShowLibrarianMenu()
    {
        int option;
        do
        {
            Console.WriteLine("\n--- Librarian Menu ---");
            Console.WriteLine("1. List all books");
            Console.WriteLine("2. Search book");
            Console.WriteLine("3. Check out a book");
            Console.WriteLine("4. Return a book");
            Console.WriteLine("5. Add a new book");
            Console.WriteLine("6. Remove a book");
            Console.WriteLine("7. Exit");

            if(!int.TryParse(Console.ReadLine(), out option)) { option = -1; }

            switch (option)
            {
                case 1: ListBooks(); break;
                case 2: SearchBookPrompt(); break;
                case 3: UpdateBookStatus("Checked Out"); break;
                case 4: UpdateBookStatus("Available"); break;
                case 5: AddNewBook(); break;
                case 6: DeleteBook(); break;
                case 7: Console.WriteLine("Exiting..."); break;
                default: Console.WriteLine("Invalid option."); break;
            }

        } while (option != 7);
    }

    private void ShowMemberMenu()
    {
        int option;
        do
        {
            Console.WriteLine("\n--- Member Menu ---");
            Console.WriteLine("1. Search book");
            Console.WriteLine("2. Borrow a book");
            Console.WriteLine("3. Exit");

            if(!int.TryParse(Console.ReadLine(), out option)) { option = -1; }

            switch (option)
            {
                case 1: SearchBookPrompt(); break;
                case 2: UpdateBookStatus("Checked Out"); break;
                case 3: Console.WriteLine("Goodbye!"); break;
                default: Console.WriteLine("Invalid option."); break;
            }

        } while (option != 3);
    }

    private void ListBooks()
    {
        Console.WriteLine("\n--- All Books ---");
        for(int i = 0; i < books.GetLength(0); i++)
        {
            Console.WriteLine($"{i+1}. {books[i,0]} | {books[i,1]} | {books[i,2]}");
        }
    }

    private void SearchBookPrompt()
    {
        Console.WriteLine("Enter book title to search:");
        string search = Console.ReadLine() ?? "";
        int index = FindBook(search);

        if (index == -1)
            Console.WriteLine("Book not found.");
        else
            DisplayBookDetails(index);
    }

    private int FindBook(string query)
    {
        query = query.ToLower();
        for(int i = 0; i < books.GetLength(0); i++)
        {
            if(books[i,0].ToLower().Contains(query))
                return i;
        }
        return -1;
    }

    private void DisplayBookDetails(int index)
    {
        Console.WriteLine($"Title: {books[index,0]}");
        Console.WriteLine($"Author: {books[index,1]}");
        Console.WriteLine($"Status: {books[index,2]}");
    }

    private void UpdateBookStatus(string newStatus)
    {
        Console.WriteLine("Enter book title:");
        string search = Console.ReadLine() ?? "";
        int index = FindBook(search);

        if (index == -1)
        {
            Console.WriteLine("Book not found.");
            return;
        }

        if (books[index,2] == newStatus)
            Console.WriteLine($"Book is already {newStatus}");
        else
        {
            books[index,2] = newStatus;
            Console.WriteLine($"Book status updated to {newStatus}");
        }
    }

    private void AddNewBook()
    {
        Console.WriteLine("Enter book title:");
        string title = Console.ReadLine() ?? "";
        Console.WriteLine("Enter author name:");
        string author = Console.ReadLine() ?? "";

        int currentRows = books.GetLength(0);
        string[,] newBooks = new string[currentRows + 1, 3];

        for(int i = 0; i < currentRows; i++)
            for(int j = 0; j < 3; j++)
                newBooks[i,j] = books[i,j];

        newBooks[currentRows,0] = title;
        newBooks[currentRows,1] = author;
        newBooks[currentRows,2] = "Available";

        books = newBooks;
        Console.WriteLine("Book added successfully!");
    }

    private void DeleteBook()
    {
        Console.WriteLine("Enter title of book to remove:");
        string search = Console.ReadLine() ?? "";
        int index = FindBook(search);

        if(index == -1)
        {
            Console.WriteLine("Book not found.");
            return;
        }

        int rows = books.GetLength(0);
        string[,] updatedBooks = new string[rows-1,3];
        int newRow = 0;

        for(int i = 0; i < rows; i++)
        {
            if(i == index) continue;
            for(int j = 0; j < 3; j++)
                updatedBooks[newRow,j] = books[i,j];
            newRow++;
        }

        books = updatedBooks;
        Console.WriteLine("Book removed successfully!");
    }
}


