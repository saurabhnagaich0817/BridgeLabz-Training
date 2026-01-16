using BookSelf.Models;

namespace BookSelf.DataStructures
{
    class BookLinkedList
    {
        private Node head;

        private class Node
        {
            public Book Data;
            public Node Next;

            public Node(Book data)
            {
                Data = data;
                Next = null;
            }
        }

        public void Add(Book book)
        {
            Node newNode = new Node(book);
            newNode.Next = head;
            head = newNode;
        }

        public bool Remove(string title)
        {
            Node temp = head;
            Node prev = null;

            while (temp != null)
            {
                if (temp.Data.GetTitle() == title)
                {
                    if (prev == null)
                        head = temp.Next;
                    else
                        prev.Next = temp.Next;

                    return true;
                }

                prev = temp;
                temp = temp.Next;
            }
            return false;
        }

        public bool Exists(string title)
        {
            Node temp = head;
            while (temp != null)
            {
                if (temp.Data.GetTitle() == title)
                    return true;
                temp = temp.Next;
            }
            return false;
        }

        public void Display()
        {
            Node temp = head;
            while (temp != null)
            {
                System.Console.WriteLine(temp.Data.ToString());
                temp = temp.Next;
            }
        }

        public bool IsEmpty()
        {
            return head == null;
        }
    }
}
