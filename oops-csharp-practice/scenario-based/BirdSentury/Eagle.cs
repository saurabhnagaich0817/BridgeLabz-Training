public class Eagle : Bird, IFlyable
{
    public Eagle(int id, string name)
        : base(id, name, "Mountains")
    {
    }

    public void Fly()
    {
        System.Console.WriteLine(birdName + " flies at high altitude.");
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
    }
}
