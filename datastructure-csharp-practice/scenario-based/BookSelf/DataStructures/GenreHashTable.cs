using BookSelf.DataStructures;

namespace BookSelf.DataStructures
{
    class GenreHashTable
    {
        private string[] genres;
        private BookLinkedList[] lists;
        private int size = 10;

        public GenreHashTable()
        {
            genres = new string[size];
            lists = new BookLinkedList[size];
        }

        private int Hash(string genre)
        {
            return genre.Length % size;
        }

        public BookLinkedList GetList(string genre)
        {
            int index = Hash(genre);

            if (genres[index] == null)
            {
                genres[index] = genre;
                lists[index] = new BookLinkedList();
            }

            return lists[index];
        }

        public void Display()
        {
            for (int i = 0; i < size; i++)
            {
                if (genres[i] != null)
                {
                    System.Console.WriteLine($"\nGenre: {genres[i]}");
                    lists[i].Display();
                }
            }
        }
    }
}
