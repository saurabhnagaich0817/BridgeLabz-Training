using System;

public class DealManagerImpl : IDealService
{
    private Item[] itemList;
    private int itemCount;

    public DealManagerImpl()
    {
        itemList = new Item[10];
        itemCount = 0;

        // default items
        InsertDefault("Laptop", 40);
        InsertDefault("Mobile", 55);
        InsertDefault("Headphones", 30);
        InsertDefault("Smart Watch", 45);
        InsertDefault("Camera", 25);
    }

    private void InsertDefault(string title, int offer)
    {
        Item obj = new Item();
        obj.AssignItem(title, offer);
        AddInternal(obj);
    }

    public void AddNewItem()
    {
        Console.Write("Enter item name: ");
        string title = Console.ReadLine();

        Console.Write("Enter discount: ");
        int offer = int.Parse(Console.ReadLine());

        Item obj = new Item();
        obj.AssignItem(title, offer);

        AddInternal(obj);
        Console.WriteLine("Item added successfully.");
    }

    private void AddInternal(Item obj)
    {
        if (itemCount == itemList.Length)
            ExpandArray();

        itemList[itemCount++] = obj;
    }

    private void ExpandArray()
    {
        Item[] temp = new Item[itemList.Length * 2];
        for (int i = 0; i < itemList.Length; i++)
            temp[i] = itemList[i];

        itemList = temp;
    }

   
    public void SortByOffer()
    {
        if (itemCount <= 1)
            return;

        int[] start = new int[itemCount];
        int[] end = new int[itemCount];
        int top = -1;

        start[++top] = 0;
        end[top] = itemCount - 1;

        while (top >= 0)
        {
            int high = end[top];
            int low = start[top--];

            int pivot = itemList[high].GetOffer();
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (itemList[j].GetOffer() > pivot)
                {
                    i++;
                    Item temp = itemList[i];
                    itemList[i] = itemList[j];
                    itemList[j] = temp;
                }
            }

            Item swap = itemList[i + 1];
            itemList[i + 1] = itemList[high];
            itemList[high] = swap;

            int p = i + 1;

            if (p - 1 > low)
            {
                start[++top] = low;
                end[top] = p - 1;
            }

            if (p + 1 < high)
            {
                start[++top] = p + 1;
                end[top] = high;
            }
        }

        Console.WriteLine("Items sorted by discount.");
    }

    public void ShowItems()
    {
        if (itemCount == 0)
        {
            Console.WriteLine("No items found.");
            return;
        }

        for (int i = 0; i < itemCount; i++)
            Console.WriteLine(itemList[i]);
    }
}
