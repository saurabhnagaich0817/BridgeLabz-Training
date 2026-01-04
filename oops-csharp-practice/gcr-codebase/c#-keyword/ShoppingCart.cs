using System;

class InventoryItem
{
    public static double OfferRate = 8;

    public readonly int ItemCode;
    public string ItemName;
    public double UnitCost;
    public int StockCount;

    public InventoryItem(int code, string name, double cost, int stock)
    {
        this.ItemCode = code;
        this.ItemName = name;
        this.UnitCost = cost;
        this.StockCount = stock;
    }

    public static void ChangeOffer(double updatedRate)
    {
        OfferRate = updatedRate;
        Console.WriteLine("Current Offer: " + OfferRate + "%");
    }

    public void ShowItemDetails(object data)
    {
        if (data is InventoryItem)
        {
            Console.WriteLine($"{ItemName} - ₹{UnitCost}, Stock: {StockCount}");
        }
    }
}

class StoreApp
{
    static void Main()
    {
        InventoryItem item1 = new InventoryItem(901, "Tablet", 32000, 3);
        InventoryItem item2 = new InventoryItem(902, "Smart Watch", 12000, 5);

        InventoryItem.ChangeOffer(12);

        item1.ShowItemDetails(item1);
        item2.ShowItemDetails(item2);
    }
}
