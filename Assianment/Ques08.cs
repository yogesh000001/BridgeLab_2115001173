using System;
using System.Linq;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method)]
class RoleAllowed : Attribute
{
    public string Role { get; }
    public RoleAllowed(string role) => Role = role;
}

class User
{
    public string Role { get; }
    public User(string role) => Role = role;
}

class AccessControl
{
    public User CurrentUser { get; set; }

    public void Execute(string methodName)
    {
        MethodInfo method = typeof(SecureOperations).GetMethod(methodName);
        RoleAllowed attribute = (RoleAllowed)method.GetCustomAttribute(typeof(RoleAllowed));

        if (attribute != null && attribute.Role != CurrentUser.Role)
        {
            Console.WriteLine("Access Denied!");
            return;
        }
        method.Invoke(new SecureOperations(), null);
    }
}

class SecureOperations
{
    [RoleAllowed("ADMIN")]
    public void AdminTask()
    {
        Console.WriteLine("Admin Task Executed");
    }
}

class Program
{
    static void Main()
    {
        AccessControl control = new AccessControl { CurrentUser = new User("USER") };
        control.Execute("AdminTask");

        control.CurrentUser = new User("ADMIN");
        control.Execute("AdminTask");
    }
}