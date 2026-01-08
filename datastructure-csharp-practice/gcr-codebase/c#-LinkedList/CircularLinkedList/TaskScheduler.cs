using System;

class TaskNode
{
    public int TaskId;
    public string TaskName;
    public int Priority;
    public string DueDate;
    public TaskNode next;

    public TaskNode(int id, string name, int priority, string dueDate)
    {
        TaskId = id;
        TaskName = name;
        Priority = priority;
        DueDate = dueDate;
        next = null;
    }
}

class TaskScheduler
{
    private TaskNode head = null;
    private TaskNode current = null;

    // Add at beginning
    public void AddAtBeginning(int id, string name, int priority, string dueDate)
    {
        TaskNode newNode = new TaskNode(id, name, priority, dueDate);

        if (head == null)
        {
            head = newNode;
            head.next = head;
            current = head;
        }
        else
        {
            TaskNode temp = head;
            while (temp.next != head)
                temp = temp.next;

            newNode.next = head;
            temp.next = newNode;
            head = newNode;
        }
    }

    // Add at end
    public void AddAtEnd(int id, string name, int priority, string dueDate)
    {
        TaskNode newNode = new TaskNode(id, name, priority, dueDate);

        if (head == null)
        {
            head = newNode;
            head.next = head;
            current = head;
        }
        else
        {
            TaskNode temp = head;
            while (temp.next != head)
                temp = temp.next;

            temp.next = newNode;
            newNode.next = head;
        }
    }

    // Add at specific position
    public void AddAtPosition(int pos, int id, string name, int priority, string dueDate)
    {
        if (pos == 1)
        {
            AddAtBeginning(id, name, priority, dueDate);
            return;
        }

        TaskNode newNode = new TaskNode(id, name, priority, dueDate);
        TaskNode temp = head;

        for (int i = 1; i < pos - 1 && temp.next != head; i++)
            temp = temp.next;

        newNode.next = temp.next;
        temp.next = newNode;
    }

    // Remove task by ID
    public void RemoveTask(int id)
    {
        if (head == null)
        {
            Console.WriteLine("No tasks to remove");
            return;
        }

        TaskNode temp = head, prev = null;

        do
        {
            if (temp.TaskId == id)
            {
                if (temp == head)
                {
                    TaskNode last = head;
                    while (last.next != head)
                        last = last.next;

                    head = head.next;
                    last.next = head;
                }
                else
                {
                    prev.next = temp.next;
                }

                Console.WriteLine("Task removed successfully");
                return;
            }

            prev = temp;
            temp = temp.next;
        } while (temp != head);

        Console.WriteLine("Task not found");
    }

    // View current task & move to next
    public void ViewNextTask()
    {
        if (current == null)
        {
            Console.WriteLine("No tasks available");
            return;
        }

        Console.WriteLine($"Current Task: {current.TaskName}");
        current = current.next;
    }

    // Display all tasks
    public void DisplayTasks()
    {
        if (head == null)
        {
            Console.WriteLine("No tasks available");
            return;
        }

        TaskNode temp = head;
        do
        {
            Console.WriteLine($"ID:{temp.TaskId}, Name:{temp.TaskName}, Priority:{temp.Priority}, Due:{temp.DueDate}");
            temp = temp.next;
        } while (temp != head);
    }

    // Search by priority
    public void SearchByPriority(int priority)
    {
        if (head == null)
        {
            Console.WriteLine("No tasks available");
            return;
        }

        TaskNode temp = head;
        bool found = false;

        do
        {
            if (temp.Priority == priority)
            {
                Console.WriteLine($"Task Found → {temp.TaskName}");
                found = true;
            }
            temp = temp.next;
        } while (temp != head);

        if (!found)
            Console.WriteLine("No task with given priority");
    }
}

class Program
{
    static void Main()
    {
        TaskScheduler ts = new TaskScheduler();

        ts.AddAtEnd(1, "Assignment", 1, "10-01-2026");
        ts.AddAtEnd(2, "Project", 2, "15-01-2026");
        ts.AddAtBeginning(3, "Exam Prep", 1, "08-01-2026");

        Console.WriteLine("\nAll Tasks:");
        ts.DisplayTasks();

        Console.WriteLine("\nNext Task:");
        ts.ViewNextTask();
        ts.ViewNextTask();

        Console.WriteLine("\nSearch Priority 1:");
        ts.SearchByPriority(1);

        Console.WriteLine("\nRemove Task ID 2:");
        ts.RemoveTask(2);

        Console.WriteLine("\nUpdated Tasks:");
        ts.DisplayTasks();
    }
}
