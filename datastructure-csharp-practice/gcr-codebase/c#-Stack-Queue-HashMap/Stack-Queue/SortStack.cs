using System;

class RecursiveStackSort
{
    static int[] stackData = new int[50];
    static int pointer = -1;

    static void Add(int value)
    {
        stackData[++pointer] = value;
    }

    static int Remove()
    {
        return stackData[pointer--];
    }

    static void PlaceInOrder(int value)
    {
        if(pointer == -1 || stackData[pointer] <= value)
        {
            Add(value);
            return;
        }

        int tempValue = Remove();
        PlaceInOrder(value);
        Add(tempValue);
    }

    static void Arrange()
    {
        if(pointer == -1)
            return;

        int current = Remove();
        Arrange();
        PlaceInOrder(current);
    }

    static void Main()
    {
        Add(45);
        Add(15);
        Add(25);
        Add(5);

        Arrange();

        while(pointer != -1)
        {
            Console.WriteLine(Remove());
        }
    }
}
