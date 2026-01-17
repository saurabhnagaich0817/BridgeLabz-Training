using System;

public class Item
{
    private string itemName;
    private int discountValue;

    public void AssignItem(string name, int discount)
    {
        itemName = name;
        discountValue = discount;
    }

    public string GetItemName()
    {
        return itemName;
    }

    public int GetOffer()
    {
        return discountValue;
    }

    public override string ToString()
    {
        return $"Item: {itemName}, Discount: {discountValue}";
    }
}
