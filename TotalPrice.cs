using System;

class Program{
    public static void TotalPrice(double UnitPrice,double Quantity){
        double TotalPrice = UnitPrice * Quantity;
        Console.WriteLine("The total purchase price is INR "+TotalPrice+" if the quantity "+Quantity+" and unit price is INR "+UnitPrice);
    }
    public static void Main(string []args){
        Console.WriteLine("Enter the unit price of the item: ");
        double UnitPrice = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the quantity of the item: ");
        double Quantity = Convert.ToDouble(Console.ReadLine());
        TotalPrice(UnitPrice,Quantity);
    }
}