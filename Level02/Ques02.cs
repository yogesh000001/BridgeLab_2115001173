using System;
//calculating the area of the circle using class
class Circle{
    private double radius;
    public Circle(double radius){
        this.radius = radius;
    }
    public void DisplayArea(){
        double area = Math.PI * Math.Pow(radius,2);
        Console.WriteLine("The area of the circle is : "+area);
    }
    public static void Main(string []args){
        Circle c = new Circle(2);
        c.DisplayArea();
    }
}