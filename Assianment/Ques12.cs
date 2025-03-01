using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        string[] lines = File.ReadAllLines("data.csv");
        HashSet<string> ids = new HashSet<string>();
        List<string> duplicates = new List<string>();

        foreach (string line in lines)
        {
            string[] columns = line.Split(',');

            if (ids.Contains(columns[0]))
            {
                duplicates.Add(line);
            }
            else
            {
                ids.Add(columns[0]);
            }
        }

        foreach (string duplicate in duplicates)
        {
            Console.WriteLine(duplicate);
        }
    }
}
