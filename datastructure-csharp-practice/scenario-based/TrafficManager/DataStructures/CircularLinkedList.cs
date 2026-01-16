using TrafficManager.Models;

namespace TrafficManager.DataStructures
{
    class CircularLinkedList
    {
        private Node tail;

        private class Node
        {
            public Vehicle Data;
            public Node Next;

            public Node(Vehicle data)
            {
                Data = data;
                Next = null;
            }
        }

        public void Add(Vehicle vehicle)
        {
            Node newNode = new Node(vehicle);

            if (tail == null)
            {
                tail = newNode;
                tail.Next = tail;
            }
            else
            {
                newNode.Next = tail.Next;
                tail.Next = newNode;
                tail = newNode;
            }
        }

        public void Remove()
        {
            if (tail == null)
            {
                System.Console.WriteLine("Roundabout is empty");
                return;
            }

            if (tail.Next == tail)
            {
                tail = null;
            }
            else
            {
                tail.Next = tail.Next.Next;
            }
        }

        public void Display()
        {
            if (tail == null)
            {
                System.Console.WriteLine("Roundabout is empty");
                return;
            }

            Node temp = tail.Next;
            do
            {
                System.Console.WriteLine(temp.Data.ToString());
                temp = temp.Next;
            }
            while (temp != tail.Next);
        }
    }
}
