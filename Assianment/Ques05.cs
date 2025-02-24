using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string text = "The Eiffel Tower is in Paris and the Statue of Liberty is in New York.";
        string[] words = text.Split(' ');
        var capitalizedWords = words.Where(w => char.IsUpper(w[0]));
        Console.WriteLine(string.Join(", ", capitalizedWords));
    }
}