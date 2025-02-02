using System;

class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public double Price { get; set; }
    public bool IsAvailable { get; set; } 

    // Constructor
    public Book(string title, string author, double price, bool isAvailable = true)
    {
        Title = title;
        Author = author;
        Price = price;
        IsAvailable = isAvailable;
    }

    // Method to Borrow a Book
    public void BorrowBook()
    {
        if (IsAvailable)
        {
            IsAvailable = false;
            Console.WriteLine("The book "+Title+" by "+Author+" has been borrowed.");
        }
        else
        {
            Console.WriteLine("Sorry, the book "+Title+" is already borrowed.");
        }
    }

    // Method to Return a Book
    public void ReturnBook()
    {
        IsAvailable = true;
        Console.WriteLine("The book "+Title+" has been returned and is now available.");
    }

    // Method to Display Book Details
    public void DisplayBook()
    {
        Console.WriteLine("Title : "+Title);
        Console.WriteLine("Author: "+Author);
        Console.WriteLine("Availability: "+(IsAvailable ? "Available" : "Not Available"));
    }

    // Main Method to Test the Class
    public static void Main(string []args)
    {
        // Creating Book Object
        Book book1 = new Book("Harry Potter", "Ramesh Kumar", 12.99);

        // Display Book Details
        Console.WriteLine("Book Details:");
        book1.DisplayBook();

        Console.WriteLine("\nBorrowing the Book...");
        book1.BorrowBook(); 

        Console.WriteLine("\nTrying to Borrow Again...");
        book1.BorrowBook(); 

        Console.WriteLine("\nReturning the Book...");
        book1.ReturnBook(); 

        Console.WriteLine("\nFinal Book Status:");
        book1.DisplayBook(); 
    }
}
