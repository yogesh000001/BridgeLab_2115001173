using System;
using System.IO;

class Program
{
    static void Main()
    {
        string inputFile = "employees.csv";
        string outputFile = "updated_employees.csv";
        string[] lines = File.ReadAllLines(inputFile);
        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(',');
            if (parts[1] == "IT")
            {
                double salary = double.Parse(parts[2]);
                salary *= 1.1;
                parts[2] = salary.ToString("F2");
                lines[i] = string.Join(",", parts);
            }
        }
        File.WriteAllLines(outputFile, lines);
        Console.WriteLine("CSV file updated successfully.");
    }
}