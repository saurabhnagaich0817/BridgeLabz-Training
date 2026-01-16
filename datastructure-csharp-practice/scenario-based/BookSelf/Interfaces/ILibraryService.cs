namespace BookSelf.Interfaces
{
    interface ILibraryService
    {
        void AddBook();
        void BorrowBook();
        void ReturnBook();
        void DisplayLibrary();
    }
}
