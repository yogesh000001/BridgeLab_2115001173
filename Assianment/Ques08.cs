using System;
using System.IO;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string filePath = "data.csv";
        string[] lines = File.ReadAllLines(filePath);
        
        foreach (string line in lines)
        {
            string[] values = line.Split(',');
            string email = values[0];
            string phone = values[1];
            
            if (!Regex.IsMatch(email, "^[^@\s]+@[^@\s]+\.[^@\s]+$") || !Regex.IsMatch(phone, "^\d{10}$"))
            {
                Console.WriteLine($"Invalid row: {line}");
            }
        }
    }
}