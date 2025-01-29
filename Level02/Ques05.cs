using System;

public class UnitConverter
{
    // Method to convert yards to feet
    public static double ConvertYardsToFeet(double yards)
    {
        double yards2feet = 3;
        return yards * yards2feet;
    }

    // Method to convert feet to yards
    public static double ConvertFeetToYards(double feet)
    {
        double feet2yards = 0.333333;
        return feet * feet2yards;
    }

    // Method to convert meters to inches
    public static double ConvertMetersToInches(double meters)
    {
        double meters2inches = 39.3701;
        return meters * meters2inches;
    }

    // Method to convert inches to meters
    public static double ConvertInchesToMeters(double inches)
    {
        double inches2meters = 0.0254;
        return inches * inches2meters;
    }

    // Method to convert inches to centimeters
    public static double ConvertInchesToCentimeters(double inches)
    {
        double inches2cm = 2.54;
        return inches * inches2cm;
    }
}

class Program
{
    static void Main()
    {
        // Example usage of the UnitConverter class methods

        // Convert yards to feet
        double yards = 5.0;
        double feet = UnitConverter.ConvertYardsToFeet(yards);
        Console.WriteLine($"{yards} yards is equal to {feet} feet.");

        // Convert feet to yards
        double feetInput = 15.0;
        double yardsConverted = UnitConverter.ConvertFeetToYards(feetInput);
        Console.WriteLine($"{feetInput} feet is equal to {yardsConverted} yards.");

        // Convert meters to inches
        double meters = 10.0;
        double inches = UnitConverter.ConvertMetersToInches(meters);
        Console.WriteLine($"{meters} meters is equal to {inches} inches.");

        // Convert inches to meters
        double inchesInput = 25.0;
        double metersConverted = UnitConverter.ConvertInchesToMeters(inchesInput);
        Console.WriteLine($"{inchesInput} inches is equal to {metersConverted} meters.");

        // Convert inches to centimeters
        double inchesForCm = 10.0;
        double cm = UnitConverter.ConvertInchesToCentimeters(inchesForCm);
        Console.WriteLine($"{inchesForCm} inches is equal to {cm} centimeters.");
    }
}
