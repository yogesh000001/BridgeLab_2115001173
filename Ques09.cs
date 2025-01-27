using System;

class Program{
    public static void Rounds(double side1,double side2,double side3){
        double perimeter = side1 + side2 + side3;
        double distance = 5;
        double rounds = distance/perimeter;
        Console.WriteLine("The total number of rounds the athlete will run is "+rounds+" to complete 5 km");
    }
    public static void Main(string []args){
        Console.WriteLine("Enter the first side of triangle: ");
        double side1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the second side of triangle: ");
        double side2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the third side of triangle: ");
        double side3 = Convert.ToDouble(Console.ReadLine());
        Rounds(side1,side2,side3);
    }
}