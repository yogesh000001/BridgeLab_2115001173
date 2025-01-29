using System;

class LeapYearChecker
{
    // Method to check if the year is a leap year
    static bool IsLeapYear(int year)
    {
        // Check if the year is greater than or equal to 1582
        if (year < 1582)
        {
            Console.WriteLine("The year must be 1582 or greater (Gregorian calendar).");
            return false;
        }

        // Check for leap year using the given conditions
        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
        {
            return true;  // It's a leap year
        }
        else
        {
            return false; // It's not a leap year
        }
    }

    static void Main()
    {
        // Take input from the user
        Console.Write("Enter a year: ");
        int year = int.Parse(Console.ReadLine());

        // Check if the year is a leap year
        if (IsLeapYear(year))
        {
            Console.WriteLine(year + " is a Leap Year.");
        }
        else
        {
            Console.WriteLine(year + " is not a Leap Year.");
        }
    }
}
