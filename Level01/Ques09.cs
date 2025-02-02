using System;

public class Student
{
    public int rollNumber;

    protected string name;

    private double CGPA;

    public Student(int roll, string studentName, double cgpa)
    {
        rollNumber = roll;
        name = studentName;
        CGPA = cgpa;
    }

    public void SetCGPA(double newCGPA)
    {
        if (newCGPA >= 0.0 && newCGPA <= 10.0)
        {
            CGPA = newCGPA;
        }
        else
        {
            Console.WriteLine("Invalid CGPA. Please enter a value between 0 and 10.");
        }
    }

    public double GetCGPA()
    {
        return CGPA;
    }

    public void DisplayStudentDetails()
    {
        Console.WriteLine("Roll Number: " + rollNumber);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("CGPA: " + CGPA);
        Console.WriteLine();
    }
}

public class PostgraduateStudent : Student
{
    public string researchTopic;

    public PostgraduateStudent(int roll, string studentName, double cgpa, string topic)
        : base(roll, studentName, cgpa)
    {
        researchTopic = topic;
    }

    public void DisplayPostgraduateDetails()
    {
        Console.WriteLine("Postgraduate Student Details:");
        Console.WriteLine("Roll Number: " + rollNumber);
        Console.WriteLine("Name: " + name); 
        Console.WriteLine("Research Topic: " + researchTopic);
        Console.WriteLine("CGPA (Accessed via GetCGPA method): " + GetCGPA());
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        Student student1 = new Student(101, "Alice", 8.5);
        student1.DisplayStudentDetails();

        student1.SetCGPA(9.2);
        Console.WriteLine("Updated CGPA: " + student1.GetCGPA());
        Console.WriteLine();

        PostgraduateStudent pgStudent = new PostgraduateStudent(201, "Bob", 9.0, "Artificial Intelligence");
        pgStudent.DisplayPostgraduateDetails();
    }
}
