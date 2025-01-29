using System;

public class NumberChecker
{
    // Method to check if a number is positive or negative
    public static string IsPositive(int number)
    {
        if (number < 0)
        {
            return "negative";
        }
        else
        {
            return "positive";
        }
    }

    // Method to check if a number is even or odd
    public static string IsEven(int number)
    {
        if (number % 2 == 0)
        {
            return "even";
        }
        else
        {
            return "odd";
        }
    }

    // Method to compare two numbers
    public static int Compare(int number1, int number2)
    {
        if (number1 > number2)
        {
            return 1; // number1 is greater
        }
        else if (number1 == number2)
        {
            return 0; // numbers are equal
        }
        else
        {
            return -1; // number1 is smaller
        }
    }
}

class Program
{
    static void Main()
    {
        // Array to store 5 numbers
        int[] numbers = new int[5];

        // Take user input for 5 numbers
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Enter number {i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        // Loop through the array to check if each number is positive or negative
        for (int i = 0; i < numbers.Length; i++)
        {
            string result = NumberChecker.IsPositive(numbers[i]);
            if (result == "positive")
            {
                Console.WriteLine($"{numbers[i]} is positive and {NumberChecker.IsEven(numbers[i])}.");
            }
            else
            {
                Console.WriteLine($"{numbers[i]} is negative.");
            }
        }

        // Compare the first and last elements of the array
        int comparisonResult = NumberChecker.Compare(numbers[0], numbers[4]);
        if (comparisonResult == 1)
        {
            Console.WriteLine($"The first number {numbers[0]} is greater than the last number {numbers[4]}.");
        }
        else if (comparisonResult == 0)
        {
            Console.WriteLine($"The first number {numbers[0]} is equal to the last number {numbers[4]}.");
        }
        else
        {
            Console.WriteLine($"The first number {numbers[0]} is less than the last number {numbers[4]}.");
        }
    }
}
