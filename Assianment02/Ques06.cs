using System;

class Program{
    // Function to find the BMI of a person
    public static void BMI(double weight, double height){
        double heightCm = height / 100;
        double bmi = weight / (heightCm * heightCm);
        if (bmi <= 18.5){
            Console.WriteLine("Underweight");
        }
        else if (bmi > 18.5 && bmi <= 24.9){    
            Console.WriteLine("Normal");
        }
        else if (bmi > 25.0 && bmi <= 39.9){
            Console.WriteLine("Overweight");
        }
        else{
            Console.WriteLine("Obese");
        }
    }
    public static void Main(string[]args){
        Console.Write("Enter the wight in kg: ");
        double weight = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the height in cm: ");
        double height = Convert.ToDouble(Console.ReadLine());
        BMI(weight, height);
    }
}