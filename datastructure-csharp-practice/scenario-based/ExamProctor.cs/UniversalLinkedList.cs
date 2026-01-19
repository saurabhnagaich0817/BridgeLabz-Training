public class SimpleList
{
    public class Node
    {
        private object data;
        private Node next;

        public Node(object data)
        {
            this.data = data;
        }

        public object Data() => data;
        public Node Next() => next;
        public void SetNext(Node n) => next = n;
    }

    private Node head;
    private Node tail;

    public Node Head() => head;

    public void AddLast(object data)
    {
        Node n = new Node(data);

        if (head == null)
        {
            head = tail = n;
            return;
        }
        tail.SetNext(n);
        tail = n;
    }

    public void AddFirst(object data)
    {
        Node n = new Node(data);
        n.SetNext(head);
        head = n;

        if (tail == null)
            tail = n;
    }

    public object RemoveFirst()
    {
        if (head == null) return null;
        object val = head.Data();
        head = head.Next();
        return val;
    }
}
