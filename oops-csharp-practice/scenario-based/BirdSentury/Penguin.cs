public class Penguin : Bird, ISwimmable
{
    public Penguin(int id, string name)
        : base(id, name, "Polar Regions")
    {
    }

    public void Swim()
    {
        System.Console.WriteLine(birdName + " swims very well.");
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
    }
}
