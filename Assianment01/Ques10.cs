using System;
using System.IO;
using System.Text;

class Program
{
    static void Main()
    {
        Console.Write("Enter file path: ");
        string filePath = Console.ReadLine();
        
        using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
        using (StreamReader reader = new StreamReader(fileStream, Encoding.UTF8))
        {
            string content = reader.ReadToEnd();
            Console.WriteLine("File content:");
            Console.WriteLine(content);
        }
    }
}
