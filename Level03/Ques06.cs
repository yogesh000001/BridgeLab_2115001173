using System;

class CalendarProgram
{
    // Array to store the names of the months
    static string[] months = {
        "January", "February", "March", "April", "May", "June",
        "July", "August", "September", "October", "November", "December"
    };

    // Array to store the number of days in each month
    static int[] daysInMonth = {
        31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31
    };

    // Method to check if the year is a leap year
    static bool IsLeapYear(int year)
    {
        if (year % 4 == 0)
        {
            if (year % 100 == 0)
            {
                if (year % 400 == 0)
                    return true;
                else
                    return false;
            }
            else
                return true;
        }
        else
            return false;
    }

    // Method to get the number of days in a month
    static int GetDaysInMonth(int month, int year)
    {
        if (month == 2 && IsLeapYear(year)) // February in a leap year
        {
            return 29;
        }
        return daysInMonth[month - 1];
    }

    // Method to get the name of the month
    static string GetMonthName(int month)
    {
        return months[month - 1];
    }

    // Method to calculate the first day of the month using the Gregorian Calendar algorithm
    static int GetFirstDayOfMonth(int month, int year)
    {
        int y0 = year - (14 - month) / 12;
        int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
        int m0 = month + 12 * ((14 - month) / 12) - 2;
        int d0 = (1 + x + 31 * m0 / 12) % 7; // 1 is the first day of the month

        return d0; // Returns the first day of the month (0 = Sunday, 1 = Monday, ..., 6 = Saturday)
    }

    // Method to display the calendar
    static void DisplayCalendar(int month, int year)
    {
        int daysInMonth = GetDaysInMonth(month, year);
        int firstDay = GetFirstDayOfMonth(month, year);

        // Display the month and year
        Console.WriteLine($"{GetMonthName(month)} {year}\n");

        // Display the day headers
        Console.WriteLine("Sun Mon Tue Wed Thu Fri Sat");

        // Add indentation for the first day of the month
        for (int i = 0; i < firstDay; i++)
        {
            Console.Write("    "); // 4 spaces for indentation
        }

        // Display the days of the month
        for (int day = 1; day <= daysInMonth; day++)
        {
            Console.Write($"{day,3} "); // Right-justify days with width of 3

            if ((firstDay + day) % 7 == 0) // Move to the next line after Saturday
            {
                Console.WriteLine();
            }
        }

        Console.WriteLine(); // Newline at the end of the calendar
    }

    static void Main()
    {
        // Take user input for the month and year
        Console.Write("Enter month (1-12): ");
        int month = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter year: ");
        int year = Convert.ToInt32(Console.ReadLine());

        // Display the calendar for the given month and year
        DisplayCalendar(month, year);
    }
}
