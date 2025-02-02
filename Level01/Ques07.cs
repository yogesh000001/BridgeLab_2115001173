using System;

public class Product
{
    public string productName;
    public double price;

    public static int totalProducts = 0;

    public Product(string name, double price)
    {
        this.productName = name;
        this.price = price;
        totalProducts++;
    }

    public void DisplayProductDetails()
    {
        Console.WriteLine("Product Name: " + productName);
        Console.WriteLine("Price: $" + price);
    }

    public static void DisplayTotalProducts()
    {
        Console.WriteLine("Total Products Created: " + totalProducts);
    }
}

class Program
{
    static void Main()
    {
        Product product1 = new Product("Laptop", 999.99);
        Product product2 = new Product("Smartphone", 599.99);

        product1.DisplayProductDetails();
        product2.DisplayProductDetails();

        Product.DisplayTotalProducts();
    }
}
