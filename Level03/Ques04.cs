using System;

class NumberChecker
{
    // Method to find factors of a number and return them as an array
    public static int[] FindFactors(int number)
    {
        int count = 0;
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
                count++;
        }

        int[] factors = new int[count];
        int index = 0;
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

    // Method to find the greatest factor of a number using the factors array
    public static int FindGreatestFactor(int[] factors)
    {
        return factors[factors.Length - 1];
    }

    // Method to find the sum of the factors using the factors array
    public static int SumOfFactors(int[] factors)
    {
        int sum = 0;
        foreach (var factor in factors)
        {
            sum += factor;
        }
        return sum;
    }

    // Method to find the product of the factors using the factors array
    public static int ProductOfFactors(int[] factors)
    {
        int product = 1;
        foreach (var factor in factors)
        {
            product *= factor;
        }
        return product;
    }

    // Method to find the product of the cube of the factors using the factors array
    public static double ProductOfCubesOfFactors(int[] factors)
    {
        double product = 1;
        foreach (var factor in factors)
        {
            product *= Math.Pow(factor, 3);
        }
        return product;
    }

    // Method to check if a number is a perfect number
    public static bool IsPerfectNumber(int number)
    {
        int[] factors = FindFactors(number);
        int sum = SumOfFactors(factors) - number; // exclude the number itself
        return sum == number;
    }

    // Method to check if a number is an abundant number
    public static bool IsAbundantNumber(int number)
    {
        int[] factors = FindFactors(number);
        int sum = SumOfFactors(factors) - number; // exclude the number itself
        return sum > number;
    }

    // Method to check if a number is a deficient number
    public static bool IsDeficientNumber(int number)
    {
        int[] factors = FindFactors(number);
        int sum = SumOfFactors(factors) - number; // exclude the number itself
        return sum < number;
    }

    // Method to check if a number is a strong number
    public static bool IsStrongNumber(int number)
    {
        int sum = 0;
        int originalNumber = number;

        while (number > 0)
        {
            int digit = number % 10;
            sum += Factorial(digit);
            number /= 10;
        }

        return sum == originalNumber;
    }

    // Helper method to calculate the factorial of a number
    public static int Factorial(int n)
    {
        if (n == 0) return 1;
        int fact = 1;
        for (int i = 1; i <= n; i++)
        {
            fact *= i;
        }
        return fact;
    }

    // Main method to test the utility class
    static void Main(string[] args)
    {
        int number = 28; // You can change this number to test with different values

        int[] factors = FindFactors(number);

        Console.WriteLine("Factors of " + number + ": " + string.Join(", ", factors));
        Console.WriteLine("Greatest Factor: " + FindGreatestFactor(factors));
        Console.WriteLine("Sum of Factors: " + SumOfFactors(factors));
        Console.WriteLine("Product of Factors: " + ProductOfFactors(factors));
        Console.WriteLine("Product of Cube of Factors: " + ProductOfCubesOfFactors(factors));
        Console.WriteLine("Is Perfect Number: " + IsPerfectNumber(number));
        Console.WriteLine("Is Abundant Number: " + IsAbundantNumber(number));
        Console.WriteLine("Is Deficient Number: " + IsDeficientNumber(number));
        Console.WriteLine("Is Strong Number: " + IsStrongNumber(number));
    }
}
