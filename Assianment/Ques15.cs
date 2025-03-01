using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

class Program
{
    static string key = "1234567890123456"; 
    static string iv = "1234567890123456"; 

    static void Main()
    {
        string[] csvData = {
            "Name,Email,Salary",
            "John,john@example.com,50000",
            "Alice,alice@example.com,60000"
        };

        string encryptedFilePath = "encrypted_data.csv";
        string decryptedFilePath = "decrypted_data.csv";

        EncryptToCSV(csvData, encryptedFilePath);
        DecryptToCSV(encryptedFilePath, decryptedFilePath);
    }

    static void EncryptToCSV(string[] data, string filePath)
    {
        using (FileStream fs = new FileStream(filePath, FileMode.Create))
        using (Aes aesAlg = Aes.Create())
        using (CryptoStream cs = new CryptoStream(fs, aesAlg.CreateEncryptor(Encoding.UTF8.GetBytes(key), Encoding.UTF8.GetBytes(iv)), CryptoStreamMode.Write))
        using (StreamWriter sw = new StreamWriter(cs))
        {
            foreach (var line in data)
            {
                sw.WriteLine(line);
            }
        }
    }

    static void DecryptToCSV(string inputFile, string outputFile)
    {
        using (FileStream fs = new FileStream(inputFile, FileMode.Open))
        using (Aes aesAlg = Aes.Create())
        using (CryptoStream cs = new CryptoStream(fs, aesAlg.CreateDecryptor(Encoding.UTF8.GetBytes(key), Encoding.UTF8.GetBytes(iv)), CryptoStreamMode.Read))
        using (StreamReader sr = new StreamReader(cs))
        using (StreamWriter sw = new StreamWriter(outputFile))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                sw.WriteLine(line);
            }
        }
    }
}
