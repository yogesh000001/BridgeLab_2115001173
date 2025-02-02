using System;

class Circle
{
    // Property
    public double Radius { get; set; }

    // Default Constructor chained
    public Circle() : this(1.0)
    {
    }

    // Parameterized Constructor
    public Circle(double radius)
    {
        Radius = radius;
    }

    // Method to Calculate Area
    public double GetArea()
    {
        return Math.PI * Radius * Radius;
    }

    // Method to Display Circle Details
    public void Display()
    {
        Console.WriteLine("Radius: "+Radius);
        Console.WriteLine("Area: "+GetArea());
    }

    public static void Main(string []args)
    {
        // Using Default Constructor
        Circle circle1 = new Circle();
        Console.WriteLine("Circle 1 Details:");
        circle1.Display();

        Console.WriteLine("\n");

        // Using Parameterized Constructor
        Circle circle2 = new Circle(5.5);
        Console.WriteLine("Circle 2 Details:");
        circle2.Display();
    }
}
