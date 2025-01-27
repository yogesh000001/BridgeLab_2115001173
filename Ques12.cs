using System;

class Program{
    public static void PoundToKg(double weight){
        double kg = weight * 0.453592;
        Console.WriteLine("The weight of the person in pounds is "+weight+" and in kg is "+kg);
    }
    public static void Main(string[]args){
        Console.WriteLine("Enter the weight in pounds: ");
        double weight = Convert.ToDouble(Console.ReadLine());
        PoundToKg(weight);
    }
}