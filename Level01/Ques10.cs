using System;

public class Book
{
    public string ISBN;

    protected string title;

    private string author;

    public Book(string isbn, string bookTitle, string bookAuthor)
    {
        ISBN = isbn;
        title = bookTitle;
        author = bookAuthor;
    }

    public void SetAuthor(string newAuthor)
    {
        author = newAuthor;
    }

    public string GetAuthor()
    {
        return author;
    }

    public void DisplayBookDetails()
    {
        Console.WriteLine("ISBN: " + ISBN);
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Author: " + author);
        Console.WriteLine();
    }
}

public class EBook : Book
{
    public double fileSize; 

    public EBook(string isbn, string bookTitle, string bookAuthor, double size)
        : base(isbn, bookTitle, bookAuthor)
    {
        fileSize = size;
    }

    public void DisplayEBookDetails()
    {
        Console.WriteLine("E-Book Details:");
        Console.WriteLine("ISBN: " + ISBN); 
        Console.WriteLine("Title: " + title); 
        Console.WriteLine("File Size: " + fileSize + " MB");
        Console.WriteLine("Author (Accessed via GetAuthor method): " + GetAuthor());
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        // Creating a Book object
        Book book1 = new Book("978-3-16-148410-0", "C# Programming", "John Doe");
        book1.DisplayBookDetails();

        // Modifying author using public methods
        book1.SetAuthor("Alice Smith");
        Console.WriteLine("Updated Author: " + book1.GetAuthor());
        Console.WriteLine();

        // Creating an EBook object
        EBook ebook1 = new EBook("978-1-23-456789-7", "Python for Beginners", "Jane Doe", 5.5);
        ebook1.DisplayEBookDetails();
    }
}
