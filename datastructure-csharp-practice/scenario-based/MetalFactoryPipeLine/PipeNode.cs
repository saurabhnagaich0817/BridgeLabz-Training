public class PipeNode
{
    private int length;
    private int price;
    private PipeNode next;

    public PipeNode(int length, int price)
    {
        this.length = length;
        this.price = price;
        next = null;
    }

    public int GetLength() => length;
    public int GetPrice() => price;

    public PipeNode GetNext() => next;
    public void SetNext(PipeNode node) => next = node;

    public override string ToString()
    {
        return $"Length={length}, Price={price}";
    }
}
