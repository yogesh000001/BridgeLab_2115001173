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

        // Multi-dimensional array to store weight, height, and BMI
        double[,] personData = new double[numPersons, 3]; // Columns: [0] = weight, [1] = height, [2] = BMI
        string[] weightStatus = new string[numPersons]; // Array to store weight status

        // Input weight and height for each person
        for (int i = 0; i < numPersons; i++)
        {
            Console.WriteLine($"\nEnter details for person {i + 1}:");

            // Input weight
            while (true)
            {
                Console.Write("Weight (in kg): ");
                if (double.TryParse(Console.ReadLine(), out personData[i, 0]) && personData[i, 0] > 0)
                    break;
                else
                    Console.WriteLine("Invalid input. Please enter a positive number.");
            }

            // Input height
            while (true)
            {
                Console.Write("Height (in meters): ");
                if (double.TryParse(Console.ReadLine(), out personData[i, 1]) && personData[i, 1] > 0)
                    break;
                else
                    Console.WriteLine("Invalid input. Please enter a positive number.");
            }
        }

        // Calculate BMI and determine weight status
        for (int i = 0; i < numPersons; i++)
        {
            double weight = personData[i, 0];
            double height = personData[i, 1];
            personData[i, 2] = weight / (height * height); // Calculate BMI

            // Determine weight status
            double bmi = personData[i, 2];
            if (bmi < 18.5)
                weightStatus[i] = "Underweight";
            else if (bmi >= 18.5 && bmi < 24.9)
                weightStatus[i] = "Normal weight";
            else if (bmi >= 25 && bmi < 29.9)
                weightStatus[i] = "Overweight";
            else
                weightStatus[i] = "Obesity";
        }

        // Display the results
        Console.WriteLine("\nBMI Results:");
        Console.WriteLine("Person\tWeight (kg)\tHeight (m)\tBMI\t\tStatus");
        for (int i = 0; i < numPersons; i++)
        {
            Console.WriteLine($"{i + 1}\t{personData[i, 0]:F2}\t\t{personData[i, 1]:F2}\t\t{personData[i, 2]:F2}\t\t{weightStatus[i]}");
        }
    }
}
