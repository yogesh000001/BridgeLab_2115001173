using System;

public class Course
{
    public string courseName;
    public int duration; 
    public double fee;

    public static string instituteName = "Global Learning Academy";

    public Course(string name, int duration, double fee)
    {
        this.courseName = name;
        this.duration = duration;
        this.fee = fee;
    }

    public void DisplayCourseDetails()
    {
        Console.WriteLine("Institute Name: " + instituteName);
        Console.WriteLine("Course Name: " + courseName);
        Console.WriteLine("Duration: " + duration + " months");
        Console.WriteLine("Fee: $" + fee);
        Console.WriteLine();
    }

    public static void UpdateInstituteName(string newName)
    {
        instituteName = newName;
        Console.WriteLine("Institute name updated to: " + instituteName);
    }
}

class Program
{
    static void Main()
    {
        Course course1 = new Course("C# Programming", 3, 299.99);
        Course course2 = new Course("Python for Data Science", 4, 399.99);

        Console.WriteLine("Before updating institute name:");
        course1.DisplayCourseDetails();
        course2.DisplayCourseDetails();

        Course.UpdateInstituteName("Tech Learning Hub");

        Console.WriteLine("\nAfter updating institute name:");
        course1.DisplayCourseDetails();
        course2.DisplayCourseDetails();
    }
}
