using System;

class MyStack
{
    int[] data = new int[50];
    int pointer = -1;
    public void Insert(int value)
    {
        data[++pointer] = value;
    }

    public int Remove()
    {
        return data[pointer--];
    }

    public bool Empty()
    {
        return pointer == -1;
    }
}

class QueueWithStacks
{
    MyStack inputStack = new MyStack();
    MyStack outputStack = new MyStack();

    public void Add(int item)
    {
        inputStack.Insert(item);
    }

    public int Delete()
    {
        if(outputStack.Empty())
        {
            while(!inputStack.Empty())
            {
                outputStack.Insert(inputStack.Remove());
            }
        }
        return outputStack.Remove();
    }
}

class Demo
{
    static void Main()
    {
        QueueWithStacks queue = new QueueWithStacks();
        queue.Add(5);
        queue.Add(15);
        queue.Add(25);
        queue.Add(35);
        Console.WriteLine(queue.Delete());
        Console.WriteLine(queue.Delete());
    }
}
