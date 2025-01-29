using System;

public class FriendFinder
{
    // Method to find the youngest friend based on their age
    public static string FindYoungestFriend(int[] ages, string[] names)
    {
        int youngestAge = ages[0];
        string youngestFriend = names[0];

        // Loop through the array to find the youngest
        for (int i = 1; i < ages.Length; i++)
        {
            if (ages[i] < youngestAge)
            {
                youngestAge = ages[i];
                youngestFriend = names[i];
            }
        }

        return youngestFriend;
    }

    // Method to find the tallest friend based on their height
    public static string FindTallestFriend(double[] heights, string[] names)
    {
        double tallestHeight = heights[0];
        string tallestFriend = names[0];

        // Loop through the array to find the tallest
        for (int i = 1; i < heights.Length; i++)
        {
            if (heights[i] > tallestHeight)
            {
                tallestHeight = heights[i];
                tallestFriend = names[i];
            }
        }

        return tallestFriend;
    }
}

class Program
{
    static void Main()
    {
        // Define arrays to store the names, ages, and heights of the 3 friends
        string[] friends = { "Amar", "Akbar", "Anthony" };
        int[] ages = new int[3];
        double[] heights = new double[3];

        // Take user input for age and height of each friend
        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Enter the age of {friends[i]}: ");
            ages[i] = int.Parse(Console.ReadLine());

            Console.Write($"Enter the height (in cm) of {friends[i]}: ");
            heights[i] = double.Parse(Console.ReadLine());
        }

        // Find the youngest and tallest friends
        string youngestFriend = FriendFinder.FindYoungestFriend(ages, friends);
        string tallestFriend = FriendFinder.FindTallestFriend(heights, friends);

        // Display the results
        Console.WriteLine($"\nThe youngest friend is: {youngestFriend}");
        Console.WriteLine($"The tallest friend is: {tallestFriend}");
    }
}
