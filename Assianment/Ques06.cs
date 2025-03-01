using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method)]
class ImportantMethod : Attribute
{
    public string Level { get; }
    public ImportantMethod(string level = "HIGH")
    {
        Level = level;
    }
}

class Test
{
    [ImportantMethod("HIGH")]
    public void CriticalMethod()
    {
        Console.WriteLine("Critical method executed.");
    }

    [ImportantMethod("MEDIUM")]
    public void NormalMethod()
    {
        Console.WriteLine("Normal method executed.");
    }

    public void DisplayImportantMethods()
    {
        MethodInfo[] methods = typeof(Test).GetMethods();
        foreach (var method in methods)
        {
            var attribute = (ImportantMethod)Attribute.GetCustomAttribute(method, typeof(ImportantMethod));
            if (attribute != null)
            {
                Console.WriteLine($"Method: {method.Name}, Level: {attribute.Level}");
            }
        }
    }
}

class Program
{
    static void Main()
    {
        Test obj = new Test();
        obj.CriticalMethod();
        obj.NormalMethod();
        obj.DisplayImportantMethods();
    }
}
