public class UniversalLinkedList
{
    public class Node
    {
        private object nodeData;
        private Node nextNode;
        private Node previousNode;

        public Node(object nodeData)
        {
            this.nodeData = nodeData;
            nextNode = null;
            previousNode = null;
        }

        public object GetData() => nodeData;
        public void SetData(object nodeData) => this.nodeData = nodeData;

        public Node GetNext() => nextNode;
        public void SetNext(Node nextNode) => this.nextNode = nextNode;

        public Node GetPrev() => previousNode;
        public void SetPrev(Node previousNode) => this.previousNode = previousNode;
    }

    private Node startNode;
    private Node endNode;

    public Node GetHead() => startNode;

    // Append at end
    public void AddLast(object element)
    {
        Node createdNode = new Node(element);

        if (startNode == null)
        {
            startNode = endNode = createdNode;
            return;
        }

        endNode.SetNext(createdNode);
        createdNode.SetPrev(endNode);
        endNode = createdNode;
    }

    // Insert at front
    public void AddFirst(object element)
    {
        Node createdNode = new Node(element);

        if (startNode == null)
        {
            startNode = endNode = createdNode;
            return;
        }

        createdNode.SetNext(startNode);
        startNode.SetPrev(createdNode);
        startNode = createdNode;
    }

    // Remove from front
    public object RemoveFirst()
    {
        if (startNode == null)
            return null;

        object removedData = startNode.GetData();
        startNode = startNode.GetNext();

        if (startNode != null)
            startNode.SetPrev(null);
        else
            endNode = null;

        return removedData;
    }

    // Remove from end
    public object RemoveLast()
    {
        if (endNode == null)
            return null;

        object removedData = endNode.GetData();
        endNode = endNode.GetPrev();

        if (endNode != null)
            endNode.SetNext(null);
        else
            startNode = null;

        return removedData;
    }

    public bool IsEmpty()
    {
        return startNode == null;
    }
}
