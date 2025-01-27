using System;

class Program{
    public static void ConvertCelciusToFahneheit(double celcius){
        double fahneheit = (celcius * 9/5) + 32;
        Console.WriteLine("The "+fahneheit+" Fahrenheit is "+celcius+" Celsius");
    }
    public static void Main(string []args){
        Console.WriteLine("Enter temprature in Celcius : ");
        double celcius = Convert.ToDouble(Console.ReadLine());
        ConvertCelciusToFahneheit(celcius);
    }
}