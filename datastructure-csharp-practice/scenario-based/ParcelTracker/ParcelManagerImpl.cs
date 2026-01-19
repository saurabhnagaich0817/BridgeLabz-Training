using System;

class ParcelManager : IParcelTracker
{
    private SimpleLinkedList list;

    public ParcelManager()
    {
        list = new SimpleLinkedList();
    }

    public void InitStages()
    {
        list.AddEnd(new ParcelPoint("Packed"));
        list.AddEnd(new ParcelPoint("Shipped"));
        list.AddEnd(new ParcelPoint("Transit"));
        list.AddEnd(new ParcelPoint("Delivered"));
    }

    public void InsertStage(string after, string stage)
    {
        bool done = list.InsertAfter(
            new ParcelPoint(after),
            new ParcelPoint(stage)
        );

        if (!done)
            Console.WriteLine("Stage not found!");
    }

    public void ShowTracking()
    {
        SimpleLinkedList.Node temp = list.Head();

        if (temp == null)
        {
            Console.WriteLine("Parcel not available");
            return;
        }

        Console.WriteLine("\nParcel Tracking:");
        while (temp != null)
        {
            Console.WriteLine("-> " + temp.Data());
            temp = temp.Next();
        }
    }

    public void ClearParcel()
    {
        while (!list.Empty())
            list.RemoveStart();

        Console.WriteLine("Parcel marked as LOST");
    }
}
