using System;

class Node
{
    public int itemId;
    public string itemName;
    public int quantity;
    public double price;
    public Node next;
}

class InventoryList
{
    Node start;

    public void AddBegin(int id, string name, int qty, double pr)
    {
        Node n = new Node();
        n.itemId = id;
        n.itemName = name;
        n.quantity = qty;
        n.price = pr;

        n.next = start;
        start = n;
    }

    public void AddEnd(int id, string name, int qty, double pr)
    {
        Node n = new Node();
        n.itemId = id;
        n.itemName = name;
        n.quantity = qty;
        n.price = pr;
        n.next = null;

        if (start == null)
        {
            start = n;
            return;
        }

        Node temp = start;
        while (temp.next != null)
            temp = temp.next;

        temp.next = n;
    }

    public void Delete(int id)
    {
        if (start == null) return;

        if (start.itemId == id)
        {
            start = start.next;
            return;
        }

        Node temp = start;
        while (temp.next != null)
        {
            if (temp.next.itemId == id)
            {
                temp.next = temp.next.next;
                return;
            }
            temp = temp.next;
        }
    }

    public void UpdateQty(int id, int q)
    {
        Node temp = start;
        while (temp != null)
        {
            if (temp.itemId == id)
            {
                temp.quantity = q;
                return;
            }
            temp = temp.next;
        }
    }

    public void SearchId(int id)
    {
        Node temp = start;
        while (temp != null)
        {
            if (temp.itemId == id)
            {
                Show(temp);
                return;
            }
            temp = temp.next;
        }
        Console.WriteLine("Item not found");
    }

    public void TotalAmount()
    {
        double sum = 0;
        Node temp = start;

        while (temp != null)
        {
            sum = sum + (temp.quantity * temp.price);
            temp = temp.next;
        }
        Console.WriteLine("Total Inventory Value = " + sum);
    }

    public void Display()
    {
        Node temp = start;
        while (temp != null)
        {
            Show(temp);
            temp = temp.next;
        }
    }

    void Show(Node t)
    {
        Console.WriteLine(t.itemId + " " + t.itemName + " " + t.quantity + " " + t.price);
    }
}

class Program
{
    static void Main()
    {
        InventoryList obj = new InventoryList();

        obj.AddBegin(1, "Pen", 10, 5);
        obj.AddEnd(2, "Book", 4, 50);

        obj.Display();
        obj.UpdateQty(1, 20);
        obj.SearchId(1);
        obj.TotalAmount();
    }
}
