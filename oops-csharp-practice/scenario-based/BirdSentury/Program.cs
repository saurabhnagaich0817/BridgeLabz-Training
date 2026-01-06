


using System;

class Program
{
    static void Main()
    {
        Bird[] birdList = new Bird[]
        {
            new Eagle(1, "Golden Eagle"),
            new Sparrow(2, "House Sparrow"),
            new Duck(3, "White Duck"),
            new Penguin(4, "Emperor Penguin"),
            new Seagull(5, "Grey Seagull")
        };

        Console.WriteLine("Bird Sanctuary Report\n");

        foreach (Bird bird in birdList)
        {
            bird.DisplayDetails();

            if (bird is IFlyable)
            {
                IFlyable f = (IFlyable)bird;
                f.Fly();
            }

            if (bird is ISwimmable)
            {
                ISwimmable s = (ISwimmable)bird;
                s.Swim();
            }

            Console.WriteLine();
        }
    }
}
