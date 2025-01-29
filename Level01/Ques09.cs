using System;

class Program
{
    public static void Main()
    {
        // Prompt user for input
        Console.Write("Enter the total number of chocolates: ");
        int numberOfChocolates = int.Parse(Console.ReadLine());

        Console.Write("Enter the number of children: ");
        int numberOfChildren = int.Parse(Console.ReadLine());

        // Call the method to calculate quotient and remainder
        int[] result = FindRemainderAndQuotient(numberOfChocolates, numberOfChildren);

        // Output the result
        Console.WriteLine($"Each child gets: {result[1]} chocolates");
        Console.WriteLine($"Remaining chocolates: {result[0]}");
    }

    // Method to find quotient and remainder
    public static int[] FindRemainderAndQuotient(int number, int divisor)
    {
        int remainder = number % divisor;
        int quotient = number / divisor;
        return new int[] { remainder, quotient };
    }
}
