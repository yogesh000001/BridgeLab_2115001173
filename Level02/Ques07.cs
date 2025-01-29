using System;

public class StudentVoteChecker
{
    // Method to check if a student can vote based on their age
    public bool CanStudentVote(int age)
    {
        // Validate if age is a negative number
        if (age < 0)
        {
            return false; // Invalid age, cannot vote
        }

        // Check if age is 18 or greater to allow voting
        return age >= 18;
    }
}

class Program
{
    static void Main()
    {
        // Create an instance of the StudentVoteChecker class
        StudentVoteChecker voteChecker = new StudentVoteChecker();

        // Create an array to store the ages of 10 students
        int[] studentAges = new int[10];

        // Loop through the array and take user input for student ages
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Enter the age of student {i + 1}: ");
            int age = int.Parse(Console.ReadLine());

            // Check if the student can vote using the CanStudentVote method
            if (voteChecker.CanStudentVote(age))
            {
                Console.WriteLine($"Student {i + 1} can vote.");
            }
            else
            {
                Console.WriteLine($"Student {i + 1} cannot vote.");
            }
        }
    }
}
