using System;

class Program{
    public static void Interest(double principal, double rate, double time){
        double simpleInterest = (principal * rate * time) / 100;
        Console.WriteLine("The Simple Interest is "+simpleInterest+" for Principal "+principal+", Rate of Interest "+rate+" and Time "+time);
    }
    public static void Main(string[]args){
        Console.WriteLine("Enter the Principal: ");
        double principal = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the Rate: ");
        double rate = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the Time: ");
        double time = Convert.ToDouble(Console.ReadLine());
        Interest(principal, rate, time);
    }
}