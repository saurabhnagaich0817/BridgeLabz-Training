using System;

class ProcessNode
{
    public int ProcessId;
    public int BurstTime;
    public int RemainingTime;
    public int WaitingTime;
    public int TurnAroundTime;
    public ProcessNode next;

    public ProcessNode(int pid, int burst)
    {
        ProcessId = pid;
        BurstTime = burst;
        RemainingTime = burst;
        next = null;
    }
}

class RoundRobinScheduler
{
    private ProcessNode tail = null;
    private int processCount = 0;

    // Add process at end
    public void AddProcess(int pid, int burst)
    {
        ProcessNode newNode = new ProcessNode(pid, burst);

        if (tail == null)
        {
            tail = newNode;
            tail.next = tail;
        }
        else
        {
            newNode.next = tail.next;
            tail.next = newNode;
            tail = newNode;
        }
        processCount++;
    }

    // Display processes
    public void DisplayProcesses()
    {
        if (tail == null)
        {
            Console.WriteLine("No processes in queue");
            return;
        }

        ProcessNode temp = tail.next;
        Console.Write("Queue: ");
        do
        {
            Console.Write($"P{temp.ProcessId}({temp.RemainingTime}) ");
            temp = temp.next;
        } while (temp != tail.next);
        Console.WriteLine();
    }

    // Round Robin Scheduling
    public void Execute(int timeQuantum)
    {
        int currentTime = 0;
        ProcessNode current = tail.next;
        ProcessNode prev = tail;

        while (processCount > 0)
        {
            DisplayProcesses();

            if (current.RemainingTime > timeQuantum)
            {
                current.RemainingTime -= timeQuantum;
                currentTime += timeQuantum;
            }
            else
            {
                currentTime += current.RemainingTime;
                current.TurnAroundTime = currentTime;
                current.WaitingTime = current.TurnAroundTime - current.BurstTime;

                Console.WriteLine($"Process P{current.ProcessId} completed");

                // Remove process
                if (current == tail)
                    tail = prev;

                prev.next = current.next;
                current = current.next;
                processCount--;
                continue;
            }

            prev = current;
            current = current.next;
        }

        Console.WriteLine("\nAll processes completed.");
    }
}

class Program
{
    static void Main()
    {
        RoundRobinScheduler rr = new RoundRobinScheduler();

        rr.AddProcess(1, 10);
        rr.AddProcess(2, 5);
        rr.AddProcess(3, 8);

        int timeQuantum = 3;
        Console.WriteLine("Round Robin Scheduling Started\n");
        rr.Execute(timeQuantum);
    }
}
