using System;

class StudentNode
{
    public int roll;
    public string name;
    public int age;
    public char grade;
    public StudentNode next;
}

class StudentList
{
    StudentNode head;

    // Add at beginning
    public void AddFirst(int r, string n, int a, char g)
    {
        StudentNode s = new StudentNode();
        s.roll = r;
        s.name = n;
        s.age = a;
        s.grade = g;

        s.next = head;
        head = s;
    }

    // Add at end
    public void AddLast(int r, string n, int a, char g)
    {
        StudentNode s = new StudentNode();
        s.roll = r;
        s.name = n;
        s.age = a;
        s.grade = g;
        s.next = null;

        if (head == null)
        {
            head = s;
            return;
        }

        StudentNode temp = head;
        while (temp.next != null)
            temp = temp.next;

        temp.next = s;
    }

    // Add at position
    public void AddAtPos(int pos, int r, string n, int a, char g)
    {
        if (pos == 1)
        {
            AddFirst(r, n, a, g);
            return;
        }

        StudentNode temp = head;
        for (int i = 1; i < pos - 1 && temp != null; i++)
            temp = temp.next;

        if (temp == null) return;

        StudentNode s = new StudentNode();
        s.roll = r;
        s.name = n;
        s.age = a;
        s.grade = g;

        s.next = temp.next;
        temp.next = s;
    }

    // Delete by Roll Number
    public void Delete(int r)
    {
        if (head == null) return;

        if (head.roll == r)
        {
            head = head.next;
            return;
        }

        StudentNode temp = head;
        while (temp.next != null)
        {
            if (temp.next.roll == r)
            {
                temp.next = temp.next.next;
                return;
            }
            temp = temp.next;
        }
    }

    // Search by Roll Number
    public void Search(int r)
    {
        StudentNode temp = head;
        while (temp != null)
        {
            if (temp.roll == r)
            {
                Show(temp);
                return;
            }
            temp = temp.next;
        }
        Console.WriteLine("Student not found");
    }

    // Update Grade
    public void UpdateGrade(int r, char g)
    {
        StudentNode temp = head;
        while (temp != null)
        {
            if (temp.roll == r)
            {
                temp.grade = g;
                return;
            }
            temp = temp.next;
        }
    }

    // Display all
    public void Display()
    {
        StudentNode temp = head;
        while (temp != null)
        {
            Show(temp);
            temp = temp.next;
        }
    }

    void Show(StudentNode s)
    {
        Console.WriteLine(
            s.roll + "  " + s.name + "  " + s.age + "  " + s.grade
        );
    }
}

class Program
{
    static void Main()
    {
        StudentList list = new StudentList();

        list.AddFirst(1, "Aman", 20, 'A');
        list.AddLast(2, "Ravi", 21, 'B');
        list.AddAtPos(2, 3, "Neha", 19, 'A');

        list.Display();

        list.UpdateGrade(2, 'A');
        list.Search(2);

        list.Delete(1);
        Console.WriteLine("After Deletion:");
        list.Display();
    }
}
