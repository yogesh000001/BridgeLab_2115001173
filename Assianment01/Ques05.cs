using System;
using System.IO;

class Program
{
    static void ReadFileLineByLine(string filePath){
        try{
            using (StreamReader reader = new StreamReader(filePath)) {
                string line;
                while ((line = reader.ReadLine()) != null){
                    Console.WriteLine(line); 
                }
            }
        }
        catch (Exception ex){
            Console.WriteLine("Error: " + ex.Message); 
        }
    }

    static void Main()
    {
        Console.Write("Enter the file path: ");
        string filePath = Console.ReadLine();

        ReadFileLineByLine(filePath);
    }
}
