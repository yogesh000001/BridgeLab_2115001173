using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the number of persons:");
        int numPersons;
        
        // Validate input for number of persons
        while (!int.TryParse(Console.ReadLine(), out numPersons) || numPersons <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive number:");
        }

        // Arrays to store weight, height, BMI, and weight status
        double[] weights = new double[numPersons];
        double[] heights = new double[numPersons];
        double[] bmis = new double[numPersons];
        string[] statuses = new string[numPersons];

        for (int i = 0; i < numPersons; i++)
        {
            Console.WriteLine($"\nEnter details for person {i + 1}:");

            while (true)
            {
                Console.Write("Weight (in kg): ");
                if (double.TryParse(Console.ReadLine(), out weights[i]) && weights[i] > 0)
                    break;
                else
                    Console.WriteLine("Invalid input. Please enter a positive number.");
            }

            while (true)
            {
                Console.Write("Height (in meters): ");
                if (double.TryParse(Console.ReadLine(), out heights[i]) && heights[i] > 0)
                    break;
                else
                    Console.WriteLine("Invalid input. Please enter a positive number.");
            }
        }

        for (int i = 0; i < numPersons; i++)
        {
            bmis[i] = weights[i] / (heights[i] * heights[i]); 

            if (bmis[i] < 18.5)
                statuses[i] = "Underweight";
            else if (bmis[i] >= 18.5 && bmis[i] < 24.9)
                statuses[i] = "Normal weight";
            else if (bmis[i] >= 25 && bmis[i] < 29.9)
                statuses[i] = "Overweight";
            else
                statuses[i] = "Obesity";
        }

        Console.WriteLine("\nBMI Results:");
        Console.WriteLine("Person\tWeight (kg)\tHeight (m)\tBMI\t\tStatus");
        for (int i = 0; i < numPersons; i++)
        {
            Console.WriteLine($"{i + 1}\t{weights[i]:F2}\t\t{heights[i]:F2}\t\t{bmis[i]:F2}\t\t{statuses[i]}");
        }
    }
}
