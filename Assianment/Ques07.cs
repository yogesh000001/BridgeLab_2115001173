using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string text = "Visit https://www.google.com and http://example.org for more info.";
        Regex regex = new Regex(@"http[s]?://[^\s]+");
        MatchCollection matches = regex.Matches(text);

        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}
