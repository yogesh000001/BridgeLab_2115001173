using System;

class Program{
    //program to find the quetient and reminder
    public static double[] QuetientReminder(double numerator,double denominator){
        double quetient = 0;
        double reminder = 0;
        quetient = numerator / denominator;
        reminder = numerator % denominator;
        return new double[] {quetient,reminder};
    }
    public static void Main(string []args){
        Console.Write("Enter the numerator : ");
        double numerator = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the denominator : ");
        double denominator = Convert.ToDouble(Console.ReadLine());
        double []arr = QuetientReminder(numerator,denominator);
        Console.WriteLine("The quetient is : "+arr[0]);
        Console.WriteLine("The reminder is : "+arr[1]);
    }
}