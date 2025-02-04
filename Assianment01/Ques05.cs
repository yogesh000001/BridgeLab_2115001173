using System;

class Student
{
    public static string UniversityName = "GLA University";
    private static int totalStudents = 0;

    public readonly int RollNumber;
    public string Name { get; set; }
    public string Grade { get; set; }

    public Student(string name, int rollNumber, string grade)
    {
        this.Name = name;
        this.RollNumber = rollNumber;
        this.Grade = grade;
        totalStudents++; 
    }

    public static void DisplayTotalStudents()
    {
        Console.WriteLine("Total Students Enrolled: " + totalStudents);
    }

    public void DisplayDetails()
    {
        Console.WriteLine("Name: " + Name + ", Roll Number: " + RollNumber + ", Grade: " + Grade + ", University: " + UniversityName);
    }

    public void UpdateGrade(object obj, string newGrade)
    {
        if (obj is Student)
        {
            ((Student)obj).Grade = newGrade;
            Console.WriteLine("Grade updated successfully!");
        }
        else
        {
            Console.WriteLine("Invalid operation: Object is not a Student.");
        }
    }

    static void Main()
    {
        Student s1 = new Student("Rahul", 101, "A");
        Student s2 = new Student("Anket", 102, "B");
        
        s1.DisplayDetails();
        s2.DisplayDetails();

        Student.DisplayTotalStudents();

        s1.UpdateGrade(s2, "A+");
        s2.DisplayDetails();
    }
}
