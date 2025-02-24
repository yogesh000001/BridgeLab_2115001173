using System;
using System.Text.RegularExpressions;

class Program
{
    static bool IsValidUsername(string username)
    {
        return Regex.IsMatch(username, "^[A-Za-z][A-Za-z0-9_]{4,14}$");
    }

    static void Main()
    {
        Console.Write("Enter username: ");
        string username = Console.ReadLine();
        Console.WriteLine(IsValidUsername(username) ? "Valid" : "Invalid");
    }
}
