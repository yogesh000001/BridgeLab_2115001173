using System;
using System.Collections.Generic;

abstract class Product
{
    private int productId;
    private string name;
    protected double price;

    public int ProductId { get { return productId; } }
    public string Name { get { return name; } }

    public Product(int productId, string name, double price)
    {
        this.productId = productId;
        this.name = name;
        this.price = price;
    }

    public abstract double CalculateDiscount();

    public virtual void ShowDetails()
    {
        Console.WriteLine("Product ID: " + productId);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Price: " + price);
    }
}

interface ITaxable
{
    double CalculateTax();
    string GetTaxDetails();
}

class Electronics : Product, ITaxable
{
    private double taxRate = 0.18;
    private double discount = 0.10;

    public Electronics(int productId, string name, double price) : base(productId, name, price) { }

    public override double CalculateDiscount()
    {
        return price * discount;
    }

    public double CalculateTax()
    {
        return price * taxRate;
    }

    public string GetTaxDetails()
    {
        return "Electronics tax rate: " + (taxRate * 100) + "%";
    }

    public override void ShowDetails()
    {
        base.ShowDetails();
        Console.WriteLine(GetTaxDetails());
        Console.WriteLine("Discount: " + CalculateDiscount());
        Console.WriteLine("Final Price: " + (price + CalculateTax() - CalculateDiscount()));
        Console.WriteLine("----------------------------");
    }
}

class Clothing : Product
{
    private double discount = 0.15;

    public Clothing(int productId, string name, double price) : base(productId, name, price) { }

    public override double CalculateDiscount()
    {
        return price * discount;
    }

    public override void ShowDetails()
    {
        base.ShowDetails();
        Console.WriteLine("Discount: " + CalculateDiscount());
        Console.WriteLine("Final Price: " + (price - CalculateDiscount()));
        Console.WriteLine("----------------------------");
    }
}

class Groceries : Product, ITaxable
{
    private double taxRate = 0.05;
    
    public Groceries(int productId, string name, double price) : base(productId, name, price) { }

    public override double CalculateDiscount()
    {
        return 0;
    }

    public double CalculateTax()
    {
        return price * taxRate;
    }

    public string GetTaxDetails()
    {
        return "Groceries tax rate: " + (taxRate * 100) + "%";
    }

    public override void ShowDetails()
    {
        base.ShowDetails();
        Console.WriteLine(GetTaxDetails());
        Console.WriteLine("Final Price: " + (price + CalculateTax()));
        Console.WriteLine("----------------------------");
    }
}

class Store
{
    static void Main()
    {
        List<Product> products = new List<Product>
        {
            new Electronics(201, "Laptop", 60000),
            new Clothing(202, "T-Shirt", 1500),
            new Groceries(203, "Rice", 800)
        };

        foreach (var item in products)
        {
            item.ShowDetails();
        }
    }
}
