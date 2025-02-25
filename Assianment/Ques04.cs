using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method)]
class TaskInfo : Attribute
{
    public string Priority { get; }
    public string AssignedTo { get; }
    
    public TaskInfo(string priority, string assignedTo)
    {
        Priority = priority;
        AssignedTo = assignedTo;
    }
}

class TaskManager
{
    [TaskInfo("High", "John Doe")]
    public void CompleteTask()
    {
        Console.WriteLine("Task Completed");
    }
}

class Program
{
    static void Main()
    {
        MethodInfo method = typeof(TaskManager).GetMethod("CompleteTask");
        TaskInfo attribute = (TaskInfo)Attribute.GetCustomAttribute(method, typeof(TaskInfo));
        
        if (attribute != null)
        {
            Console.WriteLine("Priority: " + attribute.Priority);
            Console.WriteLine("Assigned To: " + attribute.AssignedTo);
        }
    }
}