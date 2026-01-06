public class Seagull : Bird, IFlyable, ISwimmable
{
    public Seagull(int id, string name)
        : base(id, name, "Coastal Areas")
    {
    }

    public void Fly()
    {
        System.Console.WriteLine(birdName + " flies near the sea.");
    }

    public void Swim()
    {
        System.Console.WriteLine(birdName + " can also swim.");
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
    }
}
