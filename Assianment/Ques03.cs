using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.Write("Enter hex color code: ");
        string input = Console.ReadLine();
        
        if (Regex.IsMatch(input, "^#[0-9A-Fa-f]{6}$"))
            Console.WriteLine("Valid");
        else
            Console.WriteLine("Invalid");
    }
}