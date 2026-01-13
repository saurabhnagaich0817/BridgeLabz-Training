class BookLinkedList
{
    private Node head;

    public void Add(Book book)
    {
        Node newNode = new Node(book);

        if (head == null)
        {
            head = newNode;
            return;
        }

        Node temp = head;
        while (temp.next != null)
        {
            temp = temp.next;
        }
        temp.next = newNode;
    }

    public void Display()
    {
        if (head == null)
        {
            System.Console.WriteLine("No books available");
            return;
        }

        Node temp = head;
        while (temp != null)
        {
            System.Console.WriteLine(temp.data);
            temp = temp.next;
        }
    }

    public void SearchByAuthor(string author)
    {
        Node temp = head;
        bool found = false;

        while (temp != null)
        {
            if (temp.data.GetAuthor().Contains(author))
            {
                System.Console.WriteLine("Found  " + temp.data);
                found = true;
            }
            temp = temp.next;
        }

        if (!found)
        {
            System.Console.WriteLine("No books found by this author");
        }
    }

    public void SortAlphabetically()
    {
        if (head == null || head.next == null)
            return;

        
        for (Node i = head; i.next != null; i = i.next)
        {
            for (Node j = i.next; j != null; j = j.next)
            {
                if (string.Compare(i.data.GetTitle(), j.data.GetTitle()) > 0)
                {
                    
                    Book tempBook = i.data;
                    i.data = j.data;
                    j.data = tempBook;
                }
            }
        }
    }
}
