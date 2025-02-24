using System;

class Program
{
    static void Main()
    {
        string[] badWords = { "damn", "stupid" };
        string sentence = "This is a damn bad example with some stupid words.";

        foreach (string word in badWords)
        {
            sentence = sentence.Replace(word, "****");
        }

        Console.WriteLine(sentence);
    }
}
