using System;

class Program{
    public static void swap(int num1,int num2){
        num1 = num1 + num2;
        num2 = num1 - num2;
        num1 = num1 - num2;
        Console.WriteLine("The swapped numbers are "+num1+" and "+num2);
    }
    public static void Main(string[]args){
        Console.WriteLine("Enter first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        swap(num1,num2);
    }
}