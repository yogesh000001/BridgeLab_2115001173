using System;
using System.Reflection;

public class Program
{
    public static void Main(string[] args)
    {
        // Get Class Information
        Type classType = Type.GetType("Person");
        Console.WriteLine("Methods:");
        foreach (var method in classType.GetMethods())
        {
            Console.WriteLine(method.Name);
        }
        Console.WriteLine("Fields:");
        foreach (var field in classType.GetFields())
        {
            Console.WriteLine(field.Name);
        }
        Console.WriteLine("Constructors:");
        foreach (var constructor in classType.GetConstructors())
        {
            Console.WriteLine(constructor.Name);
        }

        // Access Private Field
        Person person = new Person();
        FieldInfo field = typeof(Person).GetField("age", BindingFlags.NonPublic | BindingFlags.Instance);
        field.SetValue(person, 30);
        Console.WriteLine($"Age: {field.GetValue(person)}");

        // Invoke Private Method
        Calculator calculator = new Calculator();
        MethodInfo method = typeof(Calculator).GetMethod("Multiply", BindingFlags.NonPublic | BindingFlags.Instance);
        Console.WriteLine($"Multiply Result: {method.Invoke(calculator, new object[] { 5, 10 })}");

        // Dynamically Create Objects
        Type studentType = Type.GetType("Student");
        object studentObject = Activator.CreateInstance(studentType);
        Console.WriteLine($"Dynamically created object: {studentObject.GetType().Name}");
    }
}

public class Person
{
    private int age;
}

public class Calculator
{
    private int Multiply(int a, int b)
    {
        return a * b;
    }
}

public class Student
{
    public string Name { get; set; }
}
