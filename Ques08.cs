using System;

class Program
{
    public static void Main(string []args)
    {
        SolveTripDetails();
    }

    static void SolveTripDetails()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter your starting city: ");
        string fromCity = Console.ReadLine();

        Console.Write("Enter the city you are passing through: ");
        string viaCity = Console.ReadLine();

        Console.Write("Enter your destination city: ");
        string toCity = Console.ReadLine();

        Console.Write("Enter the distance from your starting city to the via city (in miles): ");
        double fromToVia = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the distance from the via city to the destination city (in miles): ");
        double viaToFinalCity = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the total time taken for the journey (in hours): ");
        double timeTaken = Convert.ToDouble(Console.ReadLine());

        double totalDistance = CalculateTotalDistance(fromToVia, viaToFinalCity);
        double averageSpeed = CalculateAverageSpeed(totalDistance, timeTaken);

        PrintResults(name, fromCity, viaCity, toCity, totalDistance, averageSpeed);
    }

    static double CalculateTotalDistance(double fromToVia, double viaToFinalCity)
    {
        return fromToVia + viaToFinalCity;
    }

    static double CalculateAverageSpeed(double totalDistance, double timeTaken)
    {
        return totalDistance / timeTaken;
    }

    static void PrintResults(string name, string fromCity, string viaCity, string toCity, double totalDistance, double averageSpeed)
    {
        Console.WriteLine();
        Console.WriteLine($"The results of the trip are:");
        Console.WriteLine($"Traveler: {name}");
        Console.WriteLine($"Route: {fromCity} -> {viaCity} -> {toCity}");
        Console.WriteLine($"Total Distance: {totalDistance} miles");
        Console.WriteLine($"Average Speed: {averageSpeed:F2} miles/hour");
    }
}
