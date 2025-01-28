using System;

class Program
{
    static void Main()
    {
        // Arrays to store ages and heights of the friends
        string[] names = { "Amar", "Akbar", "Anthony" };
        int[] ages = new int[3];
        double[] heights = new double[3];

        for (int i = 0; i < 3; i++)
        {
            while (true)
            {
                Console.WriteLine($"Enter the age of {names[i]}:");
                if (int.TryParse(Console.ReadLine(), out ages[i]) && ages[i] > 0)
                    break;
                else
                    Console.WriteLine("Invalid age. Please enter a valid positive number.");
            }

            while (true)
            {
                Console.WriteLine($"Enter the height (in cm) of {names[i]}:");
                if (double.TryParse(Console.ReadLine(), out heights[i]) && heights[i] > 0)
                    break;
                else
                    Console.WriteLine("Invalid height. Please enter a valid positive number.");
            }
        }

        int youngestIndex = 0;
        for (int i = 1; i < 3; i++)
        {
            if (ages[i] < ages[youngestIndex])
            {
                youngestIndex = i;
            }
        }

        int tallestIndex = 0;
        for (int i = 1; i < 3; i++)
        {
            if (heights[i] > heights[tallestIndex])
            {
                tallestIndex = i;
            }
        }

        Console.WriteLine($"\nThe youngest friend is {names[youngestIndex]} with an age of {ages[youngestIndex]} years.");
        Console.WriteLine($"The tallest friend is {names[tallestIndex]} with a height of {heights[tallestIndex]} cm.");
    }
}
