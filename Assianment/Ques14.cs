using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string text = "The price is $45.99, and the discount is $ 10.50.";
        Regex regex = new Regex(@"\$?\d+(\.\d{1,2})?");
        foreach (Match match in regex.Matches(text))
        {
            Console.Write(match.Value.Trim() + ", ");
        }
    }
}
