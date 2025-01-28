using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        string input = Console.ReadLine();

        // Validate input
        if (!long.TryParse(input, out long number) || number < 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive number.");
            return;
        }

        int digitCount = input.Length; 
        int[] digits = new int[digitCount];

        for (int i = 0; i < digitCount; i++)
        {
            digits[i] = input[i] - '0'; 
        }

        int[] reversedDigits = new int[digitCount];
        for (int i = 0; i < digitCount; i++)
        {
            reversedDigits[i] = digits[digitCount - 1 - i];
        }

        Console.WriteLine("\nThe reversed number is:");
        foreach (int digit in reversedDigits)
        {
            Console.Write(digit);
        }

        Console.WriteLine();
    }
}
