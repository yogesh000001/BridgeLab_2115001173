using System;
using System.IO;
using System.Text;

class Program
{
    static void Main()
    {
        Console.Write("Enter file path: ");
        string filePath = Console.ReadLine();
        
        Console.WriteLine("Enter text to write to the file (type 'exit' to stop):");
        using (StreamWriter writer = new StreamWriter(filePath, false, Encoding.UTF8))
        {
            string input;
            while ((input = Console.ReadLine()) != "exit")
            {
                writer.WriteLine(input);
            }
        }
        
        Console.WriteLine("Content written to file successfully.");
    }
}
