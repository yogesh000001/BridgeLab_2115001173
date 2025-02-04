using System;
// display the title, author and price of the book
public class Book{
    private string title;
    private string author;
    private double price;
    public Book(string title,string author,double price){
        this.title = title;
        this.author = author;
        this.price = price;
    }
    public void Display(){
        Console.WriteLine("The title of the book : "+title);
        Console.WriteLine("The author of the book : "+author);
        Console.WriteLine("The price of the book : "+price);
    }
    public static void Main(string []args){
        Book bk = new Book("Harry Potter","J.K Rowling",2345);
        bk.Display();
    }
}