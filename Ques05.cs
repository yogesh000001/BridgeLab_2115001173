using System;

class Program{
    public static void ConvertFahrenheitToCelcius(double Fahrenheit){
        double celcius = (Fahrenheit - 32) * 5/9;
        Console.WriteLine("The "+Fahrenheit+" Fahrenheit is "+celcius+" Celsius");
    }
    public static void Main(string []args){
        Console.WriteLine("Enter temprature in Fahrenheit : ");
        double Fahrenheit = Convert.ToDouble(Console.ReadLine());
        ConvertFahrenheitToCelcius(Fahrenheit);
    }
}