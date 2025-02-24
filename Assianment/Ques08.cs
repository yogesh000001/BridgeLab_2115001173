using System;

class Program
{
    static void Main()
    {
        string input = "This  is   an example    with multiple spaces.";
        string output = System.Text.RegularExpressions.Regex.Replace(input, @"\s+", " ");
        Console.WriteLine(output);
    }
}
