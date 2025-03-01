using System;
using System.IO;

class Program
{
    static void Main()
    {
        string path = "data.csv";
        if (File.Exists(path))
        {
            string[] lines = File.ReadAllLines(path);
            int count = lines.Length > 1 ? lines.Length - 1 : 0;
            Console.WriteLine("Records: " + count);
        }
        else
        {
            Console.WriteLine("File not found");
        }
    }
}