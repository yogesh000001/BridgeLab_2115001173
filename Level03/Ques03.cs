using System;

public class NumberChecker
{
    // Method to check if a number is a prime number
    public static bool IsPrime(int number)
    {
        if (number <= 1) return false;
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
                return false;
        }
        return true;
    }

    // Method to check if a number is a neon number
    public static bool IsNeon(int number)
    {
        int square = number * number;
        int sum = 0;
        while (square > 0)
        {
            sum += square % 10;
            square /= 10;
        }
        return sum == number;
    }

    // Method to check if a number is a spy number
    public static bool IsSpy(int number)
    {
        int sum = 0, product = 1;
        while (number > 0)
        {
            int digit = number % 10;
            sum += digit;
            product *= digit;
            number /= 10;
        }
        return sum == product;
    }

    // Method to check if a number is an automorphic number
    public static bool IsAutomorphic(int number)
    {
        int square = number * number;
        return square.ToString().EndsWith(number.ToString());
    }

    // Method to check if a number is a buzz number
    public static bool IsBuzz(int number)
    {
        return number % 7 == 0 || number % 10 == 7;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine($"Is {number} a Prime Number? {IsPrime(number)}");
        Console.WriteLine($"Is {number} a Neon Number? {IsNeon(number)}");
        Console.WriteLine($"Is {number} a Spy Number? {IsSpy(number)}");
        Console.WriteLine($"Is {number} an Automorphic Number? {IsAutomorphic(number)}");
        Console.WriteLine($"Is {number} a Buzz Number? {IsBuzz(number)}");
    }
}
