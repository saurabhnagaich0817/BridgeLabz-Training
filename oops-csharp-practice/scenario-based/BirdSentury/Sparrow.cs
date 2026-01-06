public class Sparrow : Bird, IFlyable
{
    public Sparrow(int id, string name)
        : base(id, name, "Urban Areas")
    {
    }

    public void Fly()
    {
        System.Console.WriteLine(birdName + " flies short distances.");
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
    }
}
