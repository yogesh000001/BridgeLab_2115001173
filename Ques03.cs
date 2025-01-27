using System;

class Program{
    public static void funct(double num1,double num2,double num3){
        double operation1 = num1 + num2 * num3;
        double operation2 = num1 * num2 + num3;
        double operation3 = num3 + num1 / num2;
        Console.WriteLine("The results of Double Operations are "+operation1+","+operation2+" and "+operation3);
    }
    public static void Main(string[]args){
        Console.WriteLine("Enter the number1: ");
        double num1 = Convert.ToDouble(Console.ReadLine());    
        Console.WriteLine("Enter the number2: ");
        double num2 = Convert.ToDouble(Console.ReadLine());    
        Console.WriteLine("Enter the number3: ");
        double num3 = Convert.ToDouble(Console.ReadLine());   
        funct(num1,num2,num3); 
    }
}