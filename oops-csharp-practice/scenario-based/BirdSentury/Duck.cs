public class Duck : Bird, ISwimmable
{
    public Duck(int id, string name)
        : base(id, name, "Lakes")
    {
    }

    public void Swim()
    {
        System.Console.WriteLine(birdName + " swims in water.");
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
    }
}
