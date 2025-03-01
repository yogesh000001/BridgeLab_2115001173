using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "largefile.csv";
        int linesProcessed = 0;
        int chunkSize = 100;
        
        using (var reader = new StreamReader(filePath))
        {
            while (!reader.EndOfStream)
            {
                int count = 0;
                while (count < chunkSize && !reader.EndOfStream)
                {
                    reader.ReadLine();
                    count++;
                }
                linesProcessed += count;
                Console.WriteLine("Processed " + linesProcessed + " lines");
            }
        }
    }
}
