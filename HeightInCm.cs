using System;

class Abc{
    public static void HeightCmToFeetInch(double height){
        double heightInInch = height / 2.54;
        double heightInFeet = heightInInch / 12;
        Console.WriteLine("Your Height in cm is "+height+" while in feet is "+heightInFeet+" and inches is "+heightInInch);
    }
    public static void Main(string []args){
        Console.WriteLine("Enter the height in cm: ");
        double height = Convert.ToDouble(Console.ReadLine());      
        HeightCmToFeetInch(height);
    }
}