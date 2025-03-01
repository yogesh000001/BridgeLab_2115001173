using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "employees.csv";
        Console.Write("Enter employee name: ");
        string searchName = Console.ReadLine();
        bool found = false;

        foreach (string line in File.ReadLines(filePath))
        {
            string[] parts = line.Split(',');
            if (parts[0].Trim().Equals(searchName, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Department: " + parts[1]);
                Console.WriteLine("Salary: " + parts[2]);
                found = true;
                break;
            }
        }

        if (!found)
        {
            Console.WriteLine("Employee not found.");
        }
    }
}
