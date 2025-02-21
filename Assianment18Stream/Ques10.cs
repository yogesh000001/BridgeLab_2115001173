using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

class WordCounter
{
    static void Main()
    {
        string filePath = "input.txt";

        if (!File.Exists(filePath))
        {
            Console.WriteLine("File not found: " + filePath);
            return;
        }

        Dictionary<string, int> wordCount = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] words = Regex.Split(line, @"\W+");
                    foreach (string word in words)
                    {
                        if (string.IsNullOrWhiteSpace(word)) 
                        {
                            continue;
                        }

                        if (wordCount.ContainsKey(word))
                        {
                            wordCount[word]++;
                        }
                        else
                        {
                            wordCount[word] = 1;
                        }
                    }
                }
            }

            int totalWords = wordCount.Values.Sum();
            Console.WriteLine("Total Number of Words: " + totalWords);

            var topWords = wordCount.OrderByDescending(w => w.Value).Take(5);

            Console.WriteLine("\nTop 5 Most Frequent Words:");
            foreach (var word in topWords)
            {
                Console.WriteLine($"{word.Key}: {word.Value} times");
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("An error occurred while reading the file.");
            Console.WriteLine("Error Details: " + ex.Message);
        }
    }
}