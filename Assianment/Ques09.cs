using System;
using System.Collections.Generic;
using System.IO;

class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Grade { get; set; }

    public override string ToString()
    {
        return $"Name: {Name}, Age: {Age}, Grade: {Grade}";
    }
}

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>();
        string[] lines = File.ReadAllLines("students.csv");
        
        foreach (string line in lines)
        {
            string[] data = line.Split(',');
            students.Add(new Student { Name = data[0], Age = int.Parse(data[1]), Grade = data[2] });
        }
        
        foreach (Student student in students)
        {
            Console.WriteLine(student);
        }
    }
}
