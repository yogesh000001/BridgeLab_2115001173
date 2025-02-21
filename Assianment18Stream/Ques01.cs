using System;
using System.IO;

class FileReadWrite
{
    static void Main()
    {
        // Source and Destination file paths
        string sourceFilePath = "source.txt";
        string destinationFilePath = "destination.txt";

        // Check if the source file exists
        if (!File.Exists(sourceFilePath))
        {
            Console.WriteLine("Source file does not exist. Please check the file path.");
            return;
        }

        try
        {
            // Open the source file for reading
            using (FileStream fsRead = new FileStream(sourceFilePath, FileMode.Open, FileAccess.Read))
            {
                // Open or create the destination file for writing
                using (FileStream fsWrite = new FileStream(destinationFilePath, FileMode.Create, FileAccess.Write))
                {
                    // Buffer to hold file data
                    byte[] buffer = new byte[1024];
                    int bytesRead;

                    // Read data from source and write to destination
                    while ((bytesRead = fsRead.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        fsWrite.Write(buffer, 0, bytesRead);
                    }
                }
            }

            Console.WriteLine("File copied successfully to " + destinationFilePath);
        }
        catch (IOException ex)
        {
            // Handle IOException (e.g., file is being used by another process)
            Console.WriteLine("An error occurred while reading or writing the file.");
            Console.WriteLine("Error Details: " + ex.Message);
        }
        catch (UnauthorizedAccessException ex)
        {
            // Handle UnauthorizedAccessException (e.g., no permission to access the file)
            Console.WriteLine("Access to the file is denied.");
            Console.WriteLine("Error Details: " + ex.Message);
        }
        catch (Exception ex)
        {
            // Handle any other exceptions
            Console.WriteLine("An unexpected error occurred.");
            Console.WriteLine("Error Details: " + ex.Message);
        }
    }
}