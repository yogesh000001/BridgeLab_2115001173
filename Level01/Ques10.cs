using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the temperature in Fahrenheit:");
        double temperature = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the wind speed in mph:");
        double windSpeed = Convert.ToDouble(Console.ReadLine());

        double windChill = CalculateWindChill(temperature, windSpeed);

        Console.WriteLine($"The wind chill temperature is: {windChill:F2}°F");
    }

    public static double CalculateWindChill(double temperature, double windSpeed)
    {
        return 35.74 + 0.6215 * temperature + (0.4275 * temperature - 35.75) * Math.Pow(windSpeed, 0.16);
    }
}
