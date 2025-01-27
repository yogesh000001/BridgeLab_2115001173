using System;

class Program{
    // Program to calculate the grade and percentage and remark of student
    public static void PercentageGrade(double maths,double physics,double chemistry){
        double total = maths + physics + chemistry;
        double percentage = (total/300)*100;
        Console.WriteLine("Percentage: "+percentage);
        if (percentage >= 80){
            Console.WriteLine("Grade: A");
            Console.WriteLine("Level 4, above agency-normalised standard");
        }
        else if (percentage >= 70 && percentage <= 79){
            Console.WriteLine("Grade: B");
            Console.WriteLine("Level 3, agency-normalised standard");
        }
        else if (percentage >= 60 && percentage <= 69){
            Console.WriteLine("Grade: C");
            Console.WriteLine("Level 2, below, but approaching agency-normalised standard");
        }
        else if (percentage >= 50 && percentage <= 59){
            Console.WriteLine("Grade: D");
            Console.WriteLine("Level 1, well below agency-normalised standard");
        }
        else if (percentage >= 40 && percentage <= 49){
            Console.WriteLine("Grade: E");
            Console.WriteLine("Level 1, too below agency-normalised standard");
        }
        else{
            Console.WriteLine("Grade: F");
            Console.WriteLine("Remedial standard");
        }
    }
    public static void Main(string[]args){
        Console.Write("Enter the marks of Maths: ");
        double maths = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the marks of Physics: ");
        double physics = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the marks of Chemistry: ");
        double chemistry = Convert.ToDouble(Console.ReadLine());
        PercentageGrade(maths,physics,chemistry);
    }
}