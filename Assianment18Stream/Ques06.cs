using System;
using System.IO;

class UpperToLowerConverter
{
    static void Main()
    {
        string sourceFilePath = "source_text.txt";
        string destinationFilePath = "converted_text.txt";

        if (!File.Exists(sourceFilePath))
        {
            Console.WriteLine("Source file does not exist. Please check the file path.");
            return;
        }

        try
        {
            using (FileStream inputFileStream = new FileStream(sourceFilePath, FileMode.Open, FileAccess.Read))
            using (BufferedStream bufferedInputStream = new BufferedStream(inputFileStream))
            using (StreamReader reader = new StreamReader(bufferedInputStream))
            using (FileStream outputFileStream = new FileStream(destinationFilePath, FileMode.Create, FileAccess.Write))
            using (BufferedStream bufferedOutputStream = new BufferedStream(outputFileStream))
            using (StreamWriter writer = new StreamWriter(bufferedOutputStream))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    writer.WriteLine(line.ToLower());
                }
            }

            Console.WriteLine("Text has been converted to lowercase and saved to " + destinationFilePath);
        }
        catch (IOException ex)
        {
            Console.WriteLine("An error occurred while processing the file.");
            Console.WriteLine("Error Details: " + ex.Message);
        }
    }
}