using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] lines = File.ReadAllLines("employees.csv");
        var sortedRecords = lines.Skip(1)
                                 .Select(line => new { Line = line, Salary = int.Parse(line.Split(',')[2]) })
                                 .OrderByDescending(x => x.Salary)
                                 .Take(5);
        
        Console.WriteLine(lines[0]);
        foreach (var record in sortedRecords)
            Console.WriteLine(record.Line);
    }
}
