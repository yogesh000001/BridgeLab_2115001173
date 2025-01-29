using System;

public class UnitConverter
{
    // Method to convert Fahrenheit to Celsius
    public static double ConvertFahrenheitToCelsius(double fahrenheit)
    {
        double fahrenheit2celsius = (fahrenheit - 32) * 5 / 9;
        return fahrenheit2celsius;
    }

    // Method to convert Celsius to Fahrenheit
    public static double ConvertCelsiusToFahrenheit(double celsius)
    {
        double celsius2fahrenheit = (celsius * 9 / 5) + 32;
        return celsius2fahrenheit;
    }

    // Method to convert pounds to kilograms
    public static double ConvertPoundsToKilograms(double pounds)
    {
        double pounds2kilograms = 0.453592;
        return pounds * pounds2kilograms;
    }

    // Method to convert kilograms to pounds
    public static double ConvertKilogramsToPounds(double kilograms)
    {
        double kilograms2pounds = 2.20462;
        return kilograms * kilograms2pounds;
    }

    // Method to convert gallons to liters
    public static double ConvertGallonsToLiters(double gallons)
    {
        double gallons2liters = 3.78541;
        return gallons * gallons2liters;
    }

    // Method to convert liters to gallons
    public static double ConvertLitersToGallons(double liters)
    {
        double liters2gallons = 0.264172;
        return liters * liters2gallons;
    }
}

class Program
{
    static void Main()
    {
        // Example usage of the UnitConverter class methods

        // Convert Fahrenheit to Celsius
        double fahrenheit = 100.0;
        double celsius = UnitConverter.ConvertFahrenheitToCelsius(fahrenheit);
        Console.WriteLine($"{fahrenheit} Fahrenheit is equal to {celsius} Celsius.");

        // Convert Celsius to Fahrenheit
        double celsiusInput = 25.0;
        double fahrenheitConverted = UnitConverter.ConvertCelsiusToFahrenheit(celsiusInput);
        Console.WriteLine($"{celsiusInput} Celsius is equal to {fahrenheitConverted} Fahrenheit.");

        // Convert pounds to kilograms
        double pounds = 150.0;
        double kilograms = UnitConverter.ConvertPoundsToKilograms(pounds);
        Console.WriteLine($"{pounds} pounds is equal to {kilograms} kilograms.");

        // Convert kilograms to pounds
        double kilogramsInput = 70.0;
        double poundsConverted = UnitConverter.ConvertKilogramsToPounds(kilogramsInput);
        Console.WriteLine($"{kilogramsInput} kilograms is equal to {poundsConverted} pounds.");

        // Convert gallons to liters
        double gallons = 10.0;
        double liters = UnitConverter.ConvertGallonsToLiters(gallons);
        Console.WriteLine($"{gallons} gallons is equal to {liters} liters.");

        // Convert liters to gallons
        double litersInput = 50.0;
        double gallonsConverted = UnitConverter.ConvertLitersToGallons(litersInput);
        Console.WriteLine($"{litersInput} liters is equal to {gallonsConverted} gallons.");
    }
}
