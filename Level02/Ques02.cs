using System;

class NaturalNumberSum
{
    // Method to find the sum of n natural numbers using recursion
    static int SumRecursive(int n)
    {
        // Base case: if n is 1, return 1
        if (n == 1)
            return 1;
        else
            return n + SumRecursive(n - 1); // Recursive call
    }

    // Method to find the sum of n natural numbers using the formula
    static int SumFormula(int n)
    {
        return (n * (n + 1)) / 2;
    }

    // Method to check if the input is a natural number
    static bool IsNaturalNumber(int n)
    {
        return n > 0;
    }

    public static void Main(string []args)
    {
        // Take input from the user
        Console.Write("Enter a natural number: ");
        int n = int.Parse(Console.ReadLine());

        // Check if the number is a natural number
        if (!IsNaturalNumber(n))
        {
            Console.WriteLine("The number is not a natural number. Exiting program.");
            return;
        }

        // Calculate sum using recursion
        int sumRecursively = SumRecursive(n);

        // Calculate sum using the formula
        int sumFormula = SumFormula(n);

        // Display the results
        Console.WriteLine("Sum of the first " + n + " natural numbers (using recursion): " + sumRecursively);
        Console.WriteLine("Sum of the first " + n + " natural numbers (using the formula): " + sumFormula);

        // Compare the results
        if (sumRecursively == sumFormula)
        {
            Console.WriteLine("The results match! Both methods are correct.");
        }
        else
        {
            Console.WriteLine("The results do not match. Something went wrong.");
        }
    }
}