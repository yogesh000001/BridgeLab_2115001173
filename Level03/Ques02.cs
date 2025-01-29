using System;
using System.Linq;

public class NumberChecker
{
    // Method to find the count of digits in the number
    public static int CountDigits(int number)
    {
        return Math.Abs(number).ToString().Length;
    }

    // Method to store the digits of the number in a digits array
    public static int[] GetDigits(int number)
    {
        return Math.Abs(number).ToString().Select(digit => int.Parse(digit.ToString())).ToArray();
    }

    // Method to reverse the digits array
    public static int[] ReverseDigits(int[] digits)
    {
        Array.Reverse(digits);
        return digits;
    }

    // Method to compare two arrays and check if they are equal
    public static bool AreArraysEqual(int[] array1, int[] array2)
    {
        if (array1 == null || array2 == null || array1.Length != array2.Length)
            return false;

        return array1.SequenceEqual(array2);
    }

    // Method to check if a number is a palindrome using the digits
    public static bool IsPalindrome(int number)
    {
        var digits = GetDigits(number);
        var reversedDigits = ReverseDigits(digits.ToArray());
        return AreArraysEqual(digits, reversedDigits);
    }

    // Method to check if a number is a duck number using the digits array
    public static bool IsDuckNumber(int number)
    {
        if (number == 0) return false; // Zero is not considered a duck number

        var digits = GetDigits(number);
        return digits.Skip(1).Contains(0); // Skip leading digit to avoid leading zeros
    }

    public static void Main()
    {
        int number = 12321;

        Console.WriteLine($"Number: {number}");
        Console.WriteLine($"Count of digits: {CountDigits(number)}");

        var digits = GetDigits(number);
        Console.WriteLine($"Digits array: {string.Join(", ", digits)}");

        var reversedDigits = ReverseDigits(digits.ToArray());
        Console.WriteLine($"Reversed digits array: {string.Join(", ", reversedDigits)}");

        Console.WriteLine($"Is the number a palindrome? {IsPalindrome(number)}");

        int duckNumber = 1023;
        Console.WriteLine($"Is {duckNumber} a duck number? {IsDuckNumber(duckNumber)}");

        int[] array1 = { 1, 2, 3 };
        int[] array2 = { 1, 2, 3 };
        Console.WriteLine($"Are arrays equal? {AreArraysEqual(array1, array2)}");
    }
}