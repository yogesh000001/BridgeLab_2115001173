using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a sentence:");
        string sentence = Console.ReadLine();
        string longestWord = FindLongestWord(sentence);
        Console.WriteLine("The longest word is: " + longestWord);
    }
    static string FindLongestWord(string sentence)
    {
        string longestWord = "";
        string currentWord = "";
        for (int i = 0; i < sentence.Length; i++)
        {
            char c = sentence[i];

            if ((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z'))
            {
                currentWord += c;
            }
            else
            {
                if (currentWord.Length > longestWord.Length)
                {
                    longestWord = currentWord;
                }
                currentWord = "";
            }
        }
        if (currentWord.Length > longestWord.Length)
        {
            longestWord = currentWord;
        }
        return longestWord;
    }
}
