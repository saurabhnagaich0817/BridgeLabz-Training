using System;

class BillManager
{
    private string[] workItems;

    // Constructor: user input ko comma se todta hai
    public BillManager(string rawInput)
    {
        workItems = rawInput.Split(',');
    }

    // Sabhi items print karta hai
    public void ShowBill()
    {
        Console.WriteLine("\n===== BILL SUMMARY =====");

        for (int index = 0; index < workItems.Length; index++)
        {
            string title;
            int cost;

            DecodeItem(workItems[index], out title, out cost);

            Console.WriteLine($"{index + 1}) {title} -> ₹{cost}");
        }
    }

    // Total amount calculate karta hai
    public int CalculateTotal()
    {
        int sum = 0;

        foreach (string item in workItems)
        {
            string title;
            int cost;

            DecodeItem(item, out title, out cost);
            sum += cost;
        }

        return sum;
    }

    // Single item ko process karta hai
    private void DecodeItem(string data, out string itemName, out int price)
    {
        itemName = "Unknown Task";
        price = 0;

        if (string.IsNullOrWhiteSpace(data))
            return;

        // Expected format: TaskName : Amount INR
        string[] chunk = data.Split('-');

        if (chunk.Length != 2)
            return;

        itemName = chunk[0].Trim();
        price = BillHelper.FetchNumber(chunk[1]);
    }
}
