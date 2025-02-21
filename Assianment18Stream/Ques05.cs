using System;
using System.IO;

class ImageToByteArray
{
    static void Main()
    {
        string sourceImagePath = "source_image.jpg";
        string destinationImagePath = "copied_image.jpg";

        if (!File.Exists(sourceImagePath))
        {
            Console.WriteLine("Source image does not exist. Please check the file path.");
            return;
        }

        try
        {
            byte[] imageBytes;

            using (FileStream fs = new FileStream(sourceImagePath, FileMode.Open, FileAccess.Read))
            using (MemoryStream ms = new MemoryStream())
            {
                fs.CopyTo(ms);
                imageBytes = ms.ToArray();
            }

            using (MemoryStream ms = new MemoryStream(imageBytes))
            using (FileStream fs = new FileStream(destinationImagePath, FileMode.Create, FileAccess.Write))
            {
                ms.CopyTo(fs);
            }

            Console.WriteLine("Image has been successfully copied to " + destinationImagePath);
        }
        catch (IOException ex)
        {
            Console.WriteLine("An error occurred while processing the image.");
            Console.WriteLine("Error Details: " + ex.Message);
        }
    }
}