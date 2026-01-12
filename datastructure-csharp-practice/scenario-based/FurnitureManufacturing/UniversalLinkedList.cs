public class UniversalLinkedList
{
    public class Node
    {
        private object value;
        private Node nextNode;
        private Node previousNode;

        public Node(object value)
        {
            this.value = value;
            nextNode = null;
            previousNode = null;
        }

        public object GetValue() => value;
        public void SetValue(object value) => this.value = value;

        public Node GetNext() => nextNode;
        public void SetNext(Node node) => nextNode = node;

        public Node GetPrev() => previousNode;
        public void SetPrev(Node node) => previousNode = node;
    }

    private Node start;
    private Node end;

    public Node GetStart() => start;

    public void InsertAtEnd(object value)
    {
        Node newNode = new Node(value);

        if (start == null)
        {
            start = end = newNode;
            return;
        }

        end.SetNext(newNode);
        newNode.SetPrev(end);
        end = newNode;
    }

    public bool IsEmpty()
    {
        return start == null;
    }
}
