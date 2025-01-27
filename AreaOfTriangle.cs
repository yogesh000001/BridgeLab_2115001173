using System;


class Program{
    public static void AreaOfTriangel(double base, double height){
        double area = 0.5 * base * height;
        Console.WriteLine("The area of the triangle is: " + area);
    }
    public static void Main(string []args){
        Console.WriteLine("Enter the base of the triangle: ");
        double base = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the height of the triangle: ");
        double height = Convert.ToDouble(Console.ReadLine());
    }
}