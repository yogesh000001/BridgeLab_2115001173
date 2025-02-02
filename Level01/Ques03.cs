using System;

class Person
{
    // Properties
    public string Name { get; set; }
    public int Age { get; set; }

    // Default Constructor
    public Person()
    {
        Name = "Unknown";
        Age = 0;
    }

    // Parameterized Constructor
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Copy Constructor cloning another person
    public Person(Person other)
    {
        Name = other.Name;
        Age = other.Age;
    }

    // Method to Display Person Details
    public void Display()
    {
        Console.WriteLine("Name: "+Name);
        Console.WriteLine("Age: "+Age);
    }

    public static void Main(string []args)
    {
        // Creating Original Person Object
        Person person1 = new Person("Alice", 25);
        Console.WriteLine("Original Person:");
        person1.Display();

        // Creating Copy using Copy Constructor
        Person person2 = new Person(person1);
        Console.WriteLine("Copied Person:");
        person2.Display();
    }
}
