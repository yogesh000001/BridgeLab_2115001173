using System;
using System.Reflection;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter method name (Add, Subtract, Multiply): ");
        string methodName = Console.ReadLine();

        Type mathType = typeof(MathOperations);
        MethodInfo method = mathType.GetMethod(methodName);
        object mathObject = Activator.CreateInstance(mathType);
        object result = method.Invoke(mathObject, new object[] { 5, 3 });
        Console.WriteLine($"Result: {result}");

        Type classType = typeof(MyClass);
        object[] attributes = classType.GetCustomAttributes(false);
        foreach (var attribute in attributes)
        {
            if (attribute is AuthorAttribute author)
            {
                Console.WriteLine($"Author: {author.Name}");
            }
        }

        Configuration config = new Configuration();
        FieldInfo field = typeof(Configuration).GetField("API_KEY", BindingFlags.NonPublic | BindingFlags.Static);
        field.SetValue(null, "NewAPIKey123");
        Console.WriteLine($"API_KEY: {field.GetValue(null)}");
    }
}

public class MathOperations
{
    public int Add(int a, int b) => a + b;
    public int Subtract(int a, int b) => a - b;
    public int Multiply(int a, int b) => a * b;
}

[Author("John Doe")]
public class MyClass {}

[AttributeUsage(AttributeTargets.Class)]
public class AuthorAttribute : Attribute
{
    public string Name { get; }
    public AuthorAttribute(string name)
    {
        Name = name;
    }
}

public class Configuration
{
    private static string API_KEY = "OldAPIKey123";
}
