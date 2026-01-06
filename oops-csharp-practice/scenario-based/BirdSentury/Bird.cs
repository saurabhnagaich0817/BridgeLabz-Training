public class Bird
{
    protected int birdId;
    protected string birdName;
    protected string habitat;

    public Bird(int id, string name, string habitat)
    {
        birdId = id;
        birdName = name;
        this.habitat = habitat;
    }

    public virtual void DisplayDetails()
    {
        System.Console.WriteLine(
            "ID: " + birdId +
            ", Name: " + birdName +
            ", Habitat: " + habitat
        );
    }
}
