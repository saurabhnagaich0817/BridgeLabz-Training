using System;

class TextNode
{
    public string text;
    public TextNode next;
    public TextNode prev;
}

class TextEditor
{
    TextNode head;
    TextNode tail;
    TextNode current;

    int maxSize = 10;
    int count = 0;

    // Add new text state
    public void AddState(string newText)
    {
        TextNode newNode = new TextNode();
        newNode.text = newText;

        // agar undo ke baad naya text aaya
        if (current != tail && current != null)
        {
            TextNode temp = current.next;
            while (temp != null)
            {
                TextNode del = temp;
                temp = temp.next;
                count--;
            }
            current.next = null;
            tail = current;
        }

        if (head == null)
        {
            head = tail = current = newNode;
            count = 1;
            return;
        }

        tail.next = newNode;
        newNode.prev = tail;
        tail = newNode;
        current = newNode;
        count++;

        // limit size
        if (count > maxSize)
        {
            head = head.next;
            head.prev = null;
            count--;
        }
    }

    // Undo
    public void Undo()
    {
        if (current != null && current.prev != null)
            current = current.prev;
        else
            Console.WriteLine("Nothing to undo");
    }

    // Redo
    public void Redo()
    {
        if (current != null && current.next != null)
            current = current.next;
        else
            Console.WriteLine("Nothing to redo");
    }

    // Show current text
    public void ShowCurrentText()
    {
        if (current != null)
            Console.WriteLine("Current Text: " + current.text);
        else
            Console.WriteLine("No text available");
    }
}

class Program
{
    static void Main()
    {
        TextEditor editor = new TextEditor();

        editor.AddState("H");
        editor.AddState("He");
        editor.AddState("Hel");
        editor.AddState("Hell");
        editor.AddState("Hello");

        editor.ShowCurrentText();

        editor.Undo();
        editor.ShowCurrentText();

        editor.Undo();
        editor.ShowCurrentText();

        editor.Redo();
        editor.ShowCurrentText();

        editor.AddState("Hello World");
        editor.ShowCurrentText();
    }
}
