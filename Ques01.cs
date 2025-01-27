using System;

class Program{
    public static void func(int num1,int num2){
        int rem = num1 % num2;
        int quetient = num1 / num2;
        Console.WriteLine("The Quotient is "+quetient+" and Remainder is "+rem+" of two numbers "+num1+" and "+num2);
    }
    public static void Main(string[]args){
        Console.WriteLine("Enter the number1: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the number2: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        func(num1,num2);
    }
}