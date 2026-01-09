using System;

class Entry
{
    public int mapKey;
    public int mapValue;
    public Entry nextNode;

    public Entry(int k, int v)
    {
        mapKey = k;
        mapValue = v;
        nextNode = null;
    }
}

class CustomHashTable
{
    Entry[] buckets = new Entry[10];

    int GetIndex(int key)
    {
        return key % buckets.Length;
    }

    public void Insert(int key, int value)
    {
        int idx = GetIndex(key);
        Entry current = buckets[idx];

        while (current != null)
        {
            if (current.mapKey == key)
            {
                current.mapValue = value;
                return;
            }
            current = current.nextNode;
        }

        Entry node = new Entry(key, value);
        node.nextNode = buckets[idx];
        buckets[idx] = node;
    }

    public int Fetch(int key)
    {
        int idx = GetIndex(key);
        Entry current = buckets[idx];

        while (current != null)
        {
            if (current.mapKey == key)
                return current.mapValue;
            current = current.nextNode;
        }
        return -1;
    }

    public void Delete(int key)
    {
        int idx = GetIndex(key);
        Entry current = buckets[idx];
        Entry previous = null;

        while (current != null)
        {
            if (current.mapKey == key)
            {
                if (previous == null)
                    buckets[idx] = current.nextNode;
                else
                    previous.nextNode = current.nextNode;
                return;
            }
            previous = current;
            current = current.nextNode;
        }
    }
}

class Demo
{
    static void Main()
    {
        CustomHashTable table = new CustomHashTable();

        table.Insert(5, 50);
        table.Insert(15, 150);
        table.Insert(25, 250);

        Console.WriteLine(table.Fetch(5));
        Console.WriteLine(table.Fetch(25));

        table.Delete(5);
        Console.WriteLine(table.Fetch(5));
    }
}
