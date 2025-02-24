using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string sentence = "This is is a repeated repeated word test.";
        var words = sentence.Split(' ');
        var repeatedWords = words.GroupBy(x => x)
                                  .Where(g => g.Count() > 1)
                                  .Select(g => g.Key);
        foreach (var word in repeatedWords)
        {
            Console.Write(word + ", ");
        }
    }
}
