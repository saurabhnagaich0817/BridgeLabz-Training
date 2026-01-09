using System;

public class CurrencyNode
{
    private int denomination;
    private int quantity;
    private CurrencyNode? nextNode;

    public CurrencyNode(int denomination, int quantity)
    {
        this.denomination = denomination;
        this.quantity = quantity;
        nextNode = null;
    }

    public int GetDenomination()
    {
        return denomination;
    }

    public int GetQuantity()
    {
        return quantity;
    }

    public CurrencyNode GetNext()
    {
        return nextNode;
    }

    public void SetNext(CurrencyNode node)
    {
        nextNode = node;
    }

    public override string ToString()
    {
        return $"₹{denomination} -> Count: {quantity}";
    }
}
