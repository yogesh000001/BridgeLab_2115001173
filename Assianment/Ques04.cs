using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        string path = "students.csv";
        if (File.Exists(path))
        {
            var lines = File.ReadAllLines(path).Skip(1);
            foreach (var line in lines)
            {
                var data = line.Split(',');
                if (int.Parse(data[1]) > 80)
                {
                    Console.WriteLine(line);
                }
            }
        }
        else
        {
            Console.WriteLine("File not found");
        }
    }
}