using System;
using BookSelf.Utility;

namespace BookSelf
{
    class Menu
    {
        public static void Show()
        {
            LibraryUtility service = new LibraryUtility();
            int choice;

            do
            {
                Console.WriteLine("\n1 Add Book");
                Console.WriteLine("2 Borrow Book");
                Console.WriteLine("3 Return Book");
                Console.WriteLine("4 Display Library");
                Console.WriteLine("0 Exit");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        service.AddBook();
                        break;

                    case 2:
                        service.BorrowBook();
                        break;

                    case 3:
                        service.ReturnBook();
                        break;

                    case 4:
                        service.DisplayLibrary();
                        break;
                }

            } while (choice != 0);
        }
    }
}
