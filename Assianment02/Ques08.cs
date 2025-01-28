using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        string input = Console.ReadLine();
        long number;

        // Validate input to ensure it's a number
        while (!long.TryParse(input, out number) || number < 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive number:");
            input = Console.ReadLine();
        }

        // Array to store the frequency of each digit (0-9)
        int[] frequency = new int[10];

        // Process each digit in the number
        foreach (char digitChar in input)
        {
            int digit = digitChar - '0'; // Convert character to integer
            frequency[digit]++;
        }

        // Display the frequency of each digit
        Console.WriteLine("\nDigit Frequency:");
        for (int i = 0; i < frequency.Length; i++)
        {
            if (frequency[i] > 0) // Only display digits that appear
            {
                Console.WriteLine($"Digit {i}: {frequency[i]}");
            }
        }
    }
}
