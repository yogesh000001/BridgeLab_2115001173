using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "employees.csv";
        string[] employees = {
            "ID,Name,Department,Salary",
            "1,John,HR,50000",
            "2,Alice,IT,60000",
            "3,Bob,Finance,55000",
            "4,Emma,Marketing,52000",
            "5,David,Sales,53000"
        };
        File.WriteAllLines(filePath, employees);
        Console.WriteLine("CSV file created successfully.");
    }
}
