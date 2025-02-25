using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
class BugReport : Attribute
{
    public string Description { get; }
    public BugReport(string description)
    {
        Description = description;
    }
}

class Program
{
    [BugReport("Bug in calculation logic")]
    [BugReport("Null reference issue occurs sometimes")]
    static void TestMethod()
    {
    }

    static void Main()
    {
        MethodInfo method = typeof(Program).GetMethod("TestMethod");
        object[] attributes = method.GetCustomAttributes(typeof(BugReport), false);
        foreach (BugReport bug in attributes)
        {
            Console.WriteLine(bug.Description);
        }
    }
}