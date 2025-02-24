using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string text = "I love Java, Python, and JavaScript, but I haven't tried Go yet.";
        string[] languages = { "Java", "Python", "JavaScript", "Go", "C#", "Ruby", "Swift", "PHP" };
        var result = languages.Where(lang => text.Contains(lang)).ToArray();
        Console.WriteLine(string.Join(", ", result));
    }
}
