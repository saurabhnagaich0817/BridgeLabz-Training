using System;

class MenuHandler
{
    private IParcelTracker tracker;

    public MenuHandler()
    {
        tracker = new ParcelManager();
        tracker.InitStages();
    }

    public void Start()
    {
        int option;
        do
        {
            Console.WriteLine("\n1 Add Stage");
            Console.WriteLine("2 Track Parcel");
            Console.WriteLine("3 Parcel Lost");
            Console.WriteLine("4 Exit");
            Console.Write("Enter choice: ");
            option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.Write("After stage: ");
                    string after = Console.ReadLine();

                    Console.Write("Stage name: ");
                    string stage = Console.ReadLine();

                    tracker.InsertStage(after, stage);
                    break;

                case 2:
                    tracker.ShowTracking();
                    break;

                case 3:
                    tracker.ClearParcel();
                    break;
            }

        } while (option != 4);
    }
}
