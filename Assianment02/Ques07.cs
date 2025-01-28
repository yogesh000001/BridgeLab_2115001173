using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the number of students:");
        int numStudents;

        // Validate input for number of students
        while (!int.TryParse(Console.ReadLine(), out numStudents) || numStudents <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive number:");
        }

        // 2D array to store marks of Physics, Chemistry, and Maths
        int[,] marks = new int[numStudents, 3]; // Columns: [0] = Physics, [1] = Chemistry, [2] = Maths
        double[] percentages = new double[numStudents]; // Array to store percentages
        string[] grades = new string[numStudents]; // Array to store grades

        // Input marks for each student
        for (int i = 0; i < numStudents; i++)
        {
            Console.WriteLine($"\nEnter marks for student {i + 1} (out of 100):");

            // Input marks for Physics
            while (true)
            {
                Console.Write("Physics: ");
                if (int.TryParse(Console.ReadLine(), out marks[i, 0]) && marks[i, 0] >= 0 && marks[i, 0] <= 100)
                    break;
                else
                    Console.WriteLine("Invalid input. Please enter a number between 0 and 100.");
            }

            // Input marks for Chemistry
            while (true)
            {
                Console.Write("Chemistry: ");
                if (int.TryParse(Console.ReadLine(), out marks[i, 1]) && marks[i, 1] >= 0 && marks[i, 1] <= 100)
                    break;
                else
                    Console.WriteLine("Invalid input. Please enter a number between 0 and 100.");
            }

            // Input marks for Maths
            while (true)
            {
                Console.Write("Maths: ");
                if (int.TryParse(Console.ReadLine(), out marks[i, 2]) && marks[i, 2] >= 0 && marks[i, 2] <= 100)
                    break;
                else
                    Console.WriteLine("Invalid input. Please enter a number between 0 and 100.");
            }
        }

        // Calculate percentages and determine grades
        for (int i = 0; i < numStudents; i++)
        {
            int totalMarks = marks[i, 0] + marks[i, 1] + marks[i, 2];
            percentages[i] = (double)totalMarks / 3; // Calculate percentage

            // Determine grade
            if (percentages[i] >= 90)
                grades[i] = "A";
            else if (percentages[i] >= 80)
                grades[i] = "B";
            else if (percentages[i] >= 70)
                grades[i] = "C";
            else if (percentages[i] >= 60)
                grades[i] = "D";
            else
                grades[i] = "F";
        }

        // Display results
        Console.WriteLine("\nResults:");
        Console.WriteLine("Student\tPhysics\tChemistry\tMaths\tPercentage\tGrade");
        for (int i = 0; i < numStudents; i++)
        {
            Console.WriteLine($"{i + 1}\t{marks[i, 0]}\t{marks[i, 1]}\t\t{marks[i, 2]}\t{percentages[i]:F2}\t\t{grades[i]}");
        }
    }
}
