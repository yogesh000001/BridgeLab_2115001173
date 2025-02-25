using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
class Todo : Attribute
{
    public string Task { get; }
    public string AssignedTo { get; }
    public string Priority { get; }
    
    public Todo(string task, string assignedTo, string priority = "MEDIUM")
    {
        Task = task;
        AssignedTo = assignedTo;
        Priority = priority;
    }
}

class Project
{
    [Todo("Implement login", "Alice", "HIGH")]
    [Todo("Optimize database queries", "Bob")]
    void FeatureA() { }

    [Todo("Enhance UI", "Charlie", "LOW")]
    void FeatureB() { }

    static void Main()
    {
        foreach (var method in typeof(Project).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public))
        {
            foreach (Todo todo in method.GetCustomAttributes(typeof(Todo), false))
            {
                Console.WriteLine($"Task: {todo.Task}, AssignedTo: {todo.AssignedTo}, Priority: {todo.Priority}");
            }
        }
    }
}
