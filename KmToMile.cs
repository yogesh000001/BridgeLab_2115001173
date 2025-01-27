using System;

class Abc{
    public static void KmToMile(double km){
        double mile = km * 0.621371;
        Console.WriteLine("The distance in miles is: " + mile);
    }
    public static void Main(string []args){
        Console.WriteLine("Enter the distance in Km: ");
        double km = Convert.ToDouble(Console.ReadLine());
        KmToMile(km);
    }
}