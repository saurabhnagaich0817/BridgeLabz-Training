class MovieLinkedList
{
    private Node head;

    public void Add(Movie movie)
    {
        Node newNode = new Node(movie);

        if(head == null)
        {
            head = newNode;
            return;
        }

        Node temp = head;
        while(temp.next != null)
        {
            temp = temp.next;
        }
        temp.next = newNode;
    }

    public void Display()
    {
        Node temp = head;

        if(temp == null)
        {
            System.Console.WriteLine("No movies available");
            return;
        }

        while(temp != null)
        {
            System.Console.WriteLine(temp.data);
            temp = temp.next;
        }
    }

    public void Search(string keyword)
    {
        Node temp = head;
        bool found = false;

        while(temp != null)
        {
            if(temp.data.GetTitle().Contains(keyword))
            {
                System.Console.WriteLine("Found  " + temp.data);
                found = true;
            }
            temp = temp.next;
        }

        if(!found)
        {
            System.Console.WriteLine("Movie not found");
        }
    }
}
