using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter an angle in degrees:");
        double angle = Convert.ToDouble(Console.ReadLine());

        double[] trigValues = CalculateTrigonometricFunctions(angle);

        Console.WriteLine($"Sine of {angle}°: {trigValues[0]:F4}");
        Console.WriteLine($"Cosine of {angle}°: {trigValues[1]:F4}");
        Console.WriteLine($"Tangent of {angle}°: {trigValues[2]:F4}");
    }

    public static double[] CalculateTrigonometricFunctions(double angle)
    {
        // Convert the angle from degrees to radians
        double radians = angle * Math.PI / 180.0;

        // Calculate sine, cosine, and tangent
        double sine = Math.Sin(radians);
        double cosine = Math.Cos(radians);
        double tangent = Math.Tan(radians);

        // Return the results as an array
        return new double[] { sine, cosine, tangent };
    }
}
