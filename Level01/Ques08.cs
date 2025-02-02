using System;

class TemperatureConverter
{
    // Convert Fahrenheit to Celsius
    static double FahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }

    // Convert Celsius to Fahrenheit
    static double CelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }

    public static void Main(string []args)
    {
        Console.WriteLine("Temperature Converter");
        Console.WriteLine("1. Convert Fahrenheit to Celsius");
        Console.WriteLine("2. Convert Celsius to Fahrenheit");
        Console.Write("Choose an option (1 or 2): ");
        
        int choice = int.Parse(Console.ReadLine());
        double temperature, converted;
        
        switch (choice)
        {
            case 1:
                Console.Write("Enter temperature in Fahrenheit: ");
                temperature = double.Parse(Console.ReadLine());
                converted = FahrenheitToCelsius(temperature);
                Console.WriteLine($"{temperature}°F is {converted:F2}°C");
                break;

            case 2:
                Console.Write("Enter temperature in Celsius: ");
                temperature = double.Parse(Console.ReadLine());
                converted = CelsiusToFahrenheit(temperature);
                Console.WriteLine($"{temperature}°C is {converted:F2}°F");
                break;

            default:
                Console.WriteLine("Invalid choice! Please select 1 or 2.");
                break;
        }
    }
}
