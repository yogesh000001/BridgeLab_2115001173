using System;
using System.Linq;

class FootballTeam
{
    static void Main(string[] args)
    {
        // Generate random heights for 11 players
        int[] heights = GenerateRandomHeights(11, 150, 250);

        // Display heights
        Console.WriteLine("Player Heights (in cm): " + string.Join(", ", heights));

        // Calculate and display results
        int sum = CalculateSum(heights);
        double mean = CalculateMean(heights);
        int shortest = FindShortestHeight(heights);
        int tallest = FindTallestHeight(heights);

        Console.WriteLine($"Sum of Heights: {sum} cm");
        Console.WriteLine($"Mean Height: {mean:F2} cm");
        Console.WriteLine($"Shortest Height: {shortest} cm");
        Console.WriteLine($"Tallest Height: {tallest} cm");
    }

    // Generate random heights for players
    static int[] GenerateRandomHeights(int size, int min, int max)
    {
        Random random = new Random();
        int[] heights = new int[size];
        for (int i = 0; i < size; i++)
        {
            heights[i] = random.Next(min, max + 1);
        }
        return heights;
    }

    // Calculate the sum of all elements in the array
    static int CalculateSum(int[] array)
    {
        return array.Sum();
    }

    // Calculate the mean height
    static double CalculateMean(int[] array)
    {
        int sum = CalculateSum(array);
        return (double)sum / array.Length;
    }

    // Find the shortest height in the array
    static int FindShortestHeight(int[] array)
    {
        return array.Min();
    }

    // Find the tallest height in the array
    static int FindTallestHeight(int[] array)
    {
        return array.Max();
    }
}
