using System;

class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public double Price { get; set; }

    // Default Constructor
    public Book()
    {
        Title = "Unknown Title";
        Author = "Unknown Author";
        Price = 0.0;
    }

    // Parameterized Constructor
    public Book(string title, string author, double price)
    {
        Title = title;
        Author = author;
        Price = price;
    }

    // Method to Display Book Details
    public void DisplayBook()
    {
        Console.WriteLine("Title: "+Title);
        Console.WriteLine("Author: "+Author);
        Console.WriteLine("Price: "+Price);
    }

    public static void Main(string []args)
    {
        Book book1 = new Book();
        Console.WriteLine("Book 1 Details:");
        book1.DisplayBook();

        Book book2 = new Book("C# Book", "Bill Gates", 15.99);
        Console.WriteLine("Book 2 Details:");
        book2.DisplayBook();
    }
}
