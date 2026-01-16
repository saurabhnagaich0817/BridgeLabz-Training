using System;
using BookSelf.Interfaces;
using BookSelf.Models;
using BookSelf.DataStructures;

namespace BookSelf.Utility
{
    class LibraryUtility : ILibraryService
    {
        private GenreHashTable table = new GenreHashTable();

        public void AddBook()
        {
            Console.Write("Enter Genre: ");
            string genre = Console.ReadLine();

            Console.Write("Enter Title: ");
            string title = Console.ReadLine();

            Console.Write("Enter Author: ");
            string author = Console.ReadLine();

            BookLinkedList list = table.GetList(genre);

            if (list.Exists(title))
            {
                Console.WriteLine("Duplicate book not allowed");
                return;
            }

            list.Add(new Book(title, author));
            Console.WriteLine("Book added");
        }

        public void BorrowBook()
        {
            Console.Write("Enter Genre: ");
            string genre = Console.ReadLine();

            Console.Write("Enter Title: ");
            string title = Console.ReadLine();

            BookLinkedList list = table.GetList(genre);

            if (list.Remove(title))
                Console.WriteLine("Book borrowed");
            else
                Console.WriteLine("Book not found");
        }

        public void ReturnBook()
        {
            AddBook(); 
        }

        public void DisplayLibrary()
        {
            table.Display();
        }
    }
}
