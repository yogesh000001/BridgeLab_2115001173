using System;

class Program
{
    static bool IsValidIP(string ip)
    {
        string[] parts = ip.Split('.');
        if (parts.Length != 4)
            return false;

        foreach (string part in parts)
        {
            if (!int.TryParse(part, out int num) || num < 0 || num > 255 || part != num.ToString())
                return false;
        }
        return true;
    }

    static void Main()
    {
        string ip = Console.ReadLine();
        Console.WriteLine(IsValidIP(ip) ? "Valid" : "Invalid");
    }
}
