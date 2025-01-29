using System;

class FactorCalculator
{
    // Method to find the factors and store them in an array
    static int[] FindFactors(int number)
    {
        int count = 0;
        
        // Find the number of factors
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
                count++;
        }

        // Initialize the array with the count of factors
        int[] factors = new int[count];
        int index = 0;

        // Store the factors in the array
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                factors[index] = i;
                index++;
            }
        }

        return factors;
    }

    // Method to calculate the sum of the factors
    static int FindSum(int[] factors)
    {
        int sum = 0;
        foreach (int factor in factors)
        {
            sum += factor;
        }
        return sum;
    }

    // Method to calculate the product of the factors
    static int FindProduct(int[] factors)
    {
        int product = 1;
        foreach (int factor in factors)
        {
            product *= factor;
        }
        return product;
    }

    // Method to calculate the sum of squares of the factors
    static double FindSumOfSquares(int[] factors)
    {
        double sumOfSquares = 0;
        foreach (int factor in factors)
        {
            sumOfSquares += Math.Pow(factor, 2);
        }
        return sumOfSquares;
    }

    static void Main()
    {
        // Take input from the user
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        // Find the factors of the number
        int[] factors = FindFactors(number);

        // Display the factors
        Console.WriteLine("Factors of the number:");
        foreach (int factor in factors)
        {
            Console.Write(factor + " ");
        }
        Console.WriteLine();

        // Calculate and display the sum, sum of squares, and product
        int sum = FindSum(factors);
        int product = FindProduct(factors);
        double sumOfSquares = FindSumOfSquares(factors);

        Console.WriteLine("Sum of factors: " + sum);
        Console.WriteLine("Product of factors: " + product);
        Console.WriteLine("Sum of squares of factors: " + sumOfSquares);
    }
}
