using System;

class Program{
    public static void PerimeterOfSquare(int side){
        int perimeter = 4 * side;
        Console.WriteLine("The length of the side is "+side+" whose perimeter is "+perimeter);
    }
    public static void Main(string []args){
        Console.WriteLine("Enter the side of the square: ");
        int side = Convert.ToInt32(Console.ReadLine());
        PerimeterOfSquare(side);
    }
}