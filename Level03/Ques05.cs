using System;

class OTPGenerator
{
    // Method to generate a 6-digit OTP number
    public static int GenerateOTP()
    {
        Random random = new Random();
        return random.Next(100000, 1000000); // Generates a number between 100000 and 999999
    }

    // Method to check if all generated OTPs are unique
    public static bool AreOTPsUnique(int[] otps)
    {
        for (int i = 0; i < otps.Length; i++)
        {
            for (int j = i + 1; j < otps.Length; j++)
            {
                if (otps[i] == otps[j])
                {
                    return false; // Return false if a duplicate OTP is found
                }
            }
        }
        return true; // Return true if all OTPs are unique
    }

    static void Main()
    {
        int[] otps = new int[10]; // Array to store 10 OTPs

        // Generate OTPs 10 times
        for (int i = 0; i < 10; i++)
        {
            otps[i] = GenerateOTP();
            Console.WriteLine($"OTP {i + 1}: {otps[i]}");
        }

        // Check if OTPs are unique
        if (AreOTPsUnique(otps))
        {
            Console.WriteLine("\nAll OTPs are unique.");
        }
        else
        {
            Console.WriteLine("\nThere are duplicate OTPs.");
        }
    }
}
