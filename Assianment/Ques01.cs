using System;
using System.IO;

class Program
{
    static void Main()
    {
        string path = "students.csv";
        string[] lines = File.ReadAllLines(path);
        
        foreach (string line in lines)
        {
            string[] data = line.Split(',');
            Console.WriteLine($"ID: {data[0]}, Name: {data[1]}, Age: {data[2]}, Marks: {data[3]}");
        }
    }
}
