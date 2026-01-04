using System;

class TransportUnit
{
    public static double EntryCharge = 1800;

    public readonly string PermitCode;
    public string HolderName;
    public string Category;

    public TransportUnit(string code, string holder, string category)
    {
        this.PermitCode = code;
        this.HolderName = holder;
        this.Category = category;
    }

    public static void ChangeEntryCharge(double newCharge)
    {
        EntryCharge = newCharge;
    }

    public void ShowInfo(object data)
    {
        if (data is TransportUnit)
        {
            Console.WriteLine($"{Category} | Permit: {PermitCode} | Owner: {HolderName}");
        }
    }
}

class StartApp
{
    static void Main()
    {
        TransportUnit t1 = new TransportUnit("MH14XY7788", "Amit", "Bike");
        t1.ShowInfo(t1);
    }
}
