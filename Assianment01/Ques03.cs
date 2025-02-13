using System;

class Node
{
    public string TextState;
    public Node Prev, Next;
    public Node(string text)
    {
        TextState = text;
        Prev = Next = null;
    }
}

class TextEditor
{
    private Node head, current;
    private int maxSize, size;
    
    public TextEditor(int historySize)
    {
        head = current = null;
        maxSize = historySize;
        size = 0;
    }

    public void AddState(string text)
    {
        Node newNode = new Node(text);
        if (current != null)
        {
            current.Next = newNode;
            newNode.Prev = current;
        }
        
        current = newNode;
        if (head == null)
            head = current;
        
        size++;
        if (size > maxSize)
        {
            head = head.Next;
            head.Prev = null;
            size--;
        }
    }

    public void Undo()
    {
        if (current != null && current.Prev != null)
        {
            current = current.Prev;
        }
        else
        {
            Console.WriteLine("No more undo available.");
        }
    }

    public void Redo()
    {
        if (current != null && current.Next != null)
        {
            current = current.Next;
        }
        else
        {
            Console.WriteLine("No more redo available.");
        }
    }

    public void DisplayCurrentState()
    {
        if (current != null)
            Console.WriteLine("Current State: " + current.TextState);
        else
            Console.WriteLine("No text available.");
    }
}

class Program
{
    public static void Main(string []args)
    {
        TextEditor editor = new TextEditor(10);
        editor.AddState("Hello");
        editor.AddState("Hello World");
        editor.AddState("Hello World!");
        
        editor.DisplayCurrentState();
        
        editor.Undo();
        editor.DisplayCurrentState();
        
        editor.Undo();
        editor.DisplayCurrentState();
        
        editor.Redo();
        editor.DisplayCurrentState();
    }
}
