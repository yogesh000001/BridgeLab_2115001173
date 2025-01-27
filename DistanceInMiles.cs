using System;

class DistanceInMiles
{
    public static void Distance(double feet){
        double miles = feet / 5280;
        double yards = feet / 3;
        Console.WriteLine("The distance in miles is " + miles+ " and distance in yards is " + yards);
    }
    public static void Main(string []args)
    {
        Console.WriteLine("Enter the distance in feet: ");
        double feet = Convert.ToDouble(Console.ReadLine());
        Distance(feet);
    }
}   