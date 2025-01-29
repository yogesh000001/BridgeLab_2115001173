using System;

class Program{
    //calculating the simple interest
    public static void SimpleInterest(double principal,double rate,double time){
        double si = (principal * rate * time)/100;
        Console.WriteLine("The Simple Interest is "+si+" for Principal "+principal+", Rate of Interest "+rate+" and Time "+time);
    }
    public static void Main(string []args){
        Console.Write("Enter the principal : ");
        double principal = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the rate : ");
        double rate = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the time : ");
        double time = Convert.ToDouble(Console.ReadLine());
        SimpleInterest(principal,rate,time);
    }
}