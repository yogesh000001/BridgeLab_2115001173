using System;
using System.Collections.Generic;

abstract class LibraryItem
{
    private int itemId;
    private string title;
    private string author;

    public int ItemId { get { return itemId; } }
    public string Title { get { return title; } }
    public string Author { get { return author; } }

    public LibraryItem(int itemId, string title, string author)
    {
        this.itemId = itemId;
        this.title = title;
        this.author = author;
    }

    public abstract int GetLoanDuration();

    public virtual void GetItemDetails()
    {
        Console.WriteLine("Item ID: " + itemId);
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Author: " + author);
        Console.WriteLine("Loan Duration: " + GetLoanDuration() + " days");
    }
}

interface IReservable
{
    void ReserveItem();
    bool CheckAvailability();
}

class Book : LibraryItem, IReservable
{
    private bool isAvailable = true;

    public Book(int itemId, string title, string author) : base(itemId, title, author) { }

    public override int GetLoanDuration()
    {
        return 14;
    }

    public void ReserveItem()
    {
        if (isAvailable)
        {
            isAvailable = false;
            Console.WriteLine("Book reserved.");
        }
        else
        {
            Console.WriteLine("Book is not available.");
        }
    }

    public bool CheckAvailability()
    {
        return isAvailable;
    }
}

class Magazine : LibraryItem
{
    public Magazine(int itemId, string title, string author) : base(itemId, title, author) { }

    public override int GetLoanDuration()
    {
        return 7;
    }
}

class DVD : LibraryItem, IReservable
{
    private bool isAvailable = true;

    public DVD(int itemId, string title, string author) : base(itemId, title, author) { }

    public override int GetLoanDuration()
    {
        return 5;
    }

    public void ReserveItem()
    {
        if (isAvailable)
        {
            isAvailable = false;
            Console.WriteLine("DVD reserved.");
        }
        else
        {
            Console.WriteLine("DVD is not available.");
        }
    }

    public bool CheckAvailability()
    {
        return isAvailable;
    }
}

class Library
{
    static void Main()
    {
        List<LibraryItem> items = new List<LibraryItem>
        {
            new Book(101, "The Great Gatsby", "F. Scott Fitzgerald"),
            new Magazine(102, "National Geographic", "Various"),
            new DVD(103, "Inception", "Christopher Nolan")
        };

        foreach (var item in items)
        {
            item.GetItemDetails();
            Console.WriteLine("----------------------------");
        }

        Book book = new Book(104, "To Kill a Mockingbird", "Harper Lee");
        book.ReserveItem();
        book.ReserveItem();
    }
}
